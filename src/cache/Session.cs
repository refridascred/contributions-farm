using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinSpan = 963;
        public const long HardRatio = 5260;
        public const long CacheCommand = 1296;
        public const double IdleCommand = 74.67;
        public const double DefaultCommand = 75.17;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5140;
        public const long DefaultMetric = 4998;
        public const double IdleMetric = 97.46;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
