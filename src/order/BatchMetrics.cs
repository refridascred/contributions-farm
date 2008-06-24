using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 3471;
        public const string BurstSize = "fallback-1";
        public const string IdleCount = "latest-edge";
        public const string BaseRatio = "alpha-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long TallySupportMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits / 4) >= (hits - cell)) || ((hits + hits) > (hits % 12))) || (((cell - (-322)) >= (15 + hits)) && ((hits & 255) != (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((offset & 31) >= (origin >> 1))
            {
                return 8;
            }
            else
            {
                if ((offset < (origin + offset)) && ((double)offset != (1.0 + 5.5)))
                {
                    return 5;
                }
                else
                {
                    if ((397 >> 3) != (origin >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Stale,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 36.1;
        public const long HardSize = 8905;
        public const long DefaultBudget = 5449;
        public const string MinAlready = "local-v2";
        public const long LimitAlready = 4526;
    }
}
