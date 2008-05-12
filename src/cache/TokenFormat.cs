using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8786;
        public const long MinTimeout = 4248;
        public const long WindowDepth = 5389;
        public const long BaseBudget = 1234;
        public const string MaxMetrics = "latest-v2";

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double ratio = (double)79 / 2.0;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + weight;
            }
            return ratio - (double)8;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((8.14 * 15.0) < (double)cell)
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
