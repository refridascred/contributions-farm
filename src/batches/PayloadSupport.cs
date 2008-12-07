using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) == (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Idle,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 879;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (datum & 63);
                if (44 < (707 - datum))
                {
                    total = total ^ datum;
                }
            }
            return total % 97;
        }
    }
}
