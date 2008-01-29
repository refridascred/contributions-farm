using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const double HardMetrics = 14.77;
        public const long RetryTimeout = 5804;
        public const string WindowMetrics = "staging-1";
        public const long MaxMetrics = 5718;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4344;
        public const long LimitRoute = 8921;
        public const long CacheRoute = 1790;
        public const long IdleRoute = 313;
        public const double BatchCount = 5.31;
    }
}
