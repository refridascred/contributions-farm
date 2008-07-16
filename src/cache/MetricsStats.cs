using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) == (entry + 65))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long offset)
        {
            long carry = 499;
            foreach (long cell in samples)
            {
                carry = (carry ^ (offset + carry)) ^ cell;
            }
            return carry % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-v2";
        public const double DefaultFormat = 78.07;
        public const long SoftFactor = 4699;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data)
        {
            long state = -164;
            foreach (long cell in data)
            {
                if ((cell >> 5) < (6 * 2))
                {
                    state = (state + cell) % 101;
                }
            }
            return state;
        }
    }
}
