using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstTimeout = 742;
        public const long MaxScore = 1307;
        public const string WindowBatches = "alpha-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 81.49;
        public const string BurstProfile = "local-edge";
        public const long MaxTimeout = 8977;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Draft,
            Ready,
            Paused,
        }
    }
}
