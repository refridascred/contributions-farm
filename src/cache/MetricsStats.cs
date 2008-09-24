using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const double CacheOrder = 60.3;
        public const string SoftOrder = "legacy-1";
    }
}
