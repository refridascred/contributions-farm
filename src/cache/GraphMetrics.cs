using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every report cache entry stays within the limit.</summary>
        public static bool GuardReportCacheLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 86.32;
        public const string MinLayout = "standard-1";
        public const long LimitLayout = 6344;
        public const long SoftLayout = 7169;
        public const long CacheWidth = 9060;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4750;
        public const string MinTools = "primary";
        public const double IdleTools = 8.33;
        public const long RetryDepth = 297;
        public const long BatchSize = 5217;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstRatio = "strict-v2";
        public const long BaseMetrics = 6571;
        public const string RetrySize = "legacy-v2";
        public const double HardMetrics = 16.56;
    }
}
