using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowBudget = 5890;
        public const string MinFarm = "stable-1";
        public const string StepTimeout = "local-edge";
    }
}
