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

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double ratio = bias + (bias + bias2);
            if (ratio < (double)40)
            {
                ratio = ratio + 8.7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio * 13.0)) + (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const double CacheOrder = 60.3;
        public const string SoftOrder = "legacy-1";
    }
}
