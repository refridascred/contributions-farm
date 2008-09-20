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

        /// <summary>Compare every pair of support entry readings.</summary>
        public static long MatchSupportEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
