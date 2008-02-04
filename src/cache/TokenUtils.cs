using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if (!((81 * 4) <= seed2))
            {
                return 1;
            }
            else
            {
                if ((seed % 7) < seed)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Queued,
            New,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "primary-edge";
        public const long RetryDepth = 6979;
        public const long LimitCommand = 724;
    }
}
