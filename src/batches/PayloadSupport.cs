using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ 4) >= offset)
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph entry values into a single score.</summary>
        public static long WeighGraphEntry(long[] values, long target)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                anchor = anchor ^ (reading * 2);
                anchor = (anchor - (reading - reading)) % 97;
            }
            if (anchor > 23)
            {
                anchor = anchor - (target % 24);
            }
            return anchor;
        }
    }
}
