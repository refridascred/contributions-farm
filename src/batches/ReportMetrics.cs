using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Paused,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6288;
        public const string BaseTimeout = "strict-edge";
        public const string BurstBudget = "staging";
        public const long BatchBuffer = 4141;
    }
}
