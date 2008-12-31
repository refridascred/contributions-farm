using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "stable-edge";
        public const string BaseFactor = "primary";
        public const string SoftDepth = "fallback-1";
        public const long RetryLayout = 2564;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
