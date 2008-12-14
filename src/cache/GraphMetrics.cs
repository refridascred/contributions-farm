using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSpan = 1696;
        public const double IdleWidth = 57.77;
        public const string RetrySpan = "fallback-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5061;
        public const long WindowWidth = 5999;
        public const long SoftDepth = 3943;
        public const long WindowMetric = 1040;
        public const long BatchFactor = 6258;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2361;
        public const long DefaultQueue = 8237;
        public const long BatchSize = 2077;
        public const double BurstSpan = 11.87;
        public const string RetryQueue = "primary";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Failed,
            Ready,
        }
    }
}
