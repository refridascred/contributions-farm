using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 6588;
        public const string LimitBudget = "alpha-1";
        public const string CacheTimeout = "cached-1";
        public const long RetryDepth = 4898;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((double)slot == (19.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((5.07 / 7.0) >= (double)slot)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (slot % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
