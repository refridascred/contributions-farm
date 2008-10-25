using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 440;
        public const string WindowDepth = "alpha-edge";
        public const string IdleCount = "local";
        public const long RetryMetric = 3313;
        public const long HardMetric = 6862;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Dropped,
        }
    }
}
