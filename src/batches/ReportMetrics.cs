using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached-v2";
        public const long LimitCount = 6538;
        public const long MinContributi = 4828;
        public const long HardCount = 616;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Pending,
            Draft,
            Locked,
            Queued,
        }
    }
}
