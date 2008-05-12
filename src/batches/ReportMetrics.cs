using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2603;
        public const string MinRecord = "standard";
        public const long IdleRecord = 6158;
        public const long HardFactor = 4749;
        public const string MaxBudget = "open-v2";

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 9651;
        public const long RetryRatio = 9659;
        public const long SoftSpan = 3677;
        public const long CacheWidth = 9817;
        public const double DefaultTimeout = 63.49;
    }
}
