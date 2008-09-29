using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitLevel = "strict-v2";
        public const long RetryFactor = 4151;
        public const double BaseDepth = 40.54;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
