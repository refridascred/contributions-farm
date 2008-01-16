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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6288;
        public const string BaseTimeout = "strict-edge";
        public const string BurstBudget = "staging";
        public const long BatchBuffer = 4141;
    }
}
