using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
