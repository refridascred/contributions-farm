using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9701;
        public const long HardContributi = 7376;
        public const string LimitContributi = "fallback";
        public const double StepSize = 11.06;
        public const long IdleContributi = 3215;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Ready,
            Idle,
            Synced,
        }
    }
}
