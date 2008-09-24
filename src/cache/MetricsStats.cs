using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next cache entry value from a seed.</summary>
        public static long SeriesCacheEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSpan = 993;
        public const string SoftCluster = "latest-v2";
        public const long MaxDepth = 1202;
        public const long MinCluster = 8982;
        public const long IdleInterval = 3874;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 47;
        public const long BatchLevel = 5020;
        public const long RetryLevel = 9815;
        public const long DefaultContext = 2151;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 * 5) > origin)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const double CacheOrder = 60.3;
        public const string SoftOrder = "legacy-1";
    }
}
