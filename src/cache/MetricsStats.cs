using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict-1";
        public const long MinTimeout = 2114;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha-v2";
        public const long HardSize = 8431;
        public const double DefaultLevel = 35.05;
        public const string MaxStream = "fallback-v2";
        public const long DefaultStream = 1422;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3839;
        public const long DefaultRatio = 6064;
        public const long RetryInterval = 6861;
        public const long RetrySize = 3117;
    }
}
