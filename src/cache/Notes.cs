using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinCount = "stable";
        public const string BurstEditor = "cached";
        public const double DefaultEditor = 95.03;
        public const double DefaultRatio = 50.94;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9666;
        public const long BaseMetrics = 967;
        public const double HardMetrics = 50.37;
        public const double RetryMetrics = 54.26;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
