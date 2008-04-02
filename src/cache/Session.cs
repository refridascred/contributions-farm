using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8328;
        public const double MinSize = 22.95;
        public const double DefaultScore = 94.01;
        public const string StepSpan = "latest-v2";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Closed,
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
