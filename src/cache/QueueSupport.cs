using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinCount = 6256;
        public const double HardFormat = 0.58;
        public const long RetryCount = 1294;
        public const string IdleCount = "fallback-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            New,
            Ready,
            Paused,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
