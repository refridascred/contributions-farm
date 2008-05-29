using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Closed,
            Synced,
            Paused,
            New,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowScore = "stable-v2";
        public const long WindowRatio = 1108;
        public const double SoftBudget = 43.57;
    }
}
