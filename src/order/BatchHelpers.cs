using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (double)hits) && ((target << 1) == (hits >> 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long carry = 132;
            foreach (long sample in data)
            {
                if ((1.01 / 4.0) > (double)sample)
                {
                    carry = carry + (sample - bound);
                }
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Draft,
        }
    }
}
