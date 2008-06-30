using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5874;
        public const string BatchCommand = "legacy-edge";
        public const long SoftCommand = 9579;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
