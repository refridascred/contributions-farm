using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 64.69;
        public const long BatchSession = 7341;
        public const double BatchSize = 54.82;
        public const long CacheRatio = 5968;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinCount = "latest-edge";
        public const long RetryMetrics = 5598;
        public const long DefaultMetrics = 9635;

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 1.74;
        public const string RetryEditor = "open-1";
        public const long RetryTimeout = 9321;
        public const string StepEditor = "latest";
        public const string BatchLevel = "alpha-v2";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
