using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1672;
        public const double WindowWidth = 28.31;
        public const long BurstAccount = 4999;
        public const double BaseAccount = 26.42;

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitLevel = 64.94;
        public const long RetryBatches = 1982;
        public const long DefaultBatches = 1702;
        public const long BurstRatio = 6927;

        /// <summary>Rank session tools input into a small class.</summary>
        public static long GradeSessionTools(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((double)bound >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((bound * 3) <= (slot << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length != (8.2 - 6.0))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
