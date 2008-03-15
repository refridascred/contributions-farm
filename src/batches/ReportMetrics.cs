using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Ready,
            Locked,
            New,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 5615;
        public const long MinAccount = 6772;
        public const double MinCount = 58.72;
    }
}
