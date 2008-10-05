using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long anchor = -251;
            foreach (long item in values)
            {
                if ((anchor + 872) <= anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor + (long)values.Length)) % 97) ^ item;
                }
            }
            if (anchor < 75)
            {
                anchor = (anchor ^ (long)values.Length) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 2) == (696 << 1))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
