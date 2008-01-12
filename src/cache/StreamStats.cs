using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardFactor = 6662;
        public const string BurstCount = "stable";
        public const double BaseTimeout = 4.9;
        public const long RetryWidth = 2750;
        public const double DefaultTimeout = 48.43;

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 37.47;
        public const long BurstCache = 302;
        public const string StepCache = "cached-edge";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 1184;
        public const long LimitMetrics = 9657;
        public const double BaseSize = 95.31;
        public const long MaxMetrics = 6291;
    }
}
