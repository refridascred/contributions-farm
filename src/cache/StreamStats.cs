using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 772;
        public const double LimitMetrics = 8.71;
        public const long RetryMetrics = 6933;
        public const string BurstMetrics = "staging-1";
        public const string CacheMetrics = "staging-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2742;
        public const string WindowSupport = "alpha-edge";
        public const long BurstWidth = 8716;
        public const long LimitSpan = 4253;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1084;
        public const long WindowBuffer = 4694;
        public const long HardFactor = 5258;
        public const long DefaultSize = 680;
        public const string StepInterval = "staging-edge";

        /// <summary>Check that every batches metric entry stays within the limit.</summary>
        public static bool CheckBatchesMetricRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
