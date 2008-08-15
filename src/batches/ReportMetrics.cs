using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 97.24;
        public const long BatchFarm = 2964;
        public const string HardFarm = "staging-1";
    }
}
