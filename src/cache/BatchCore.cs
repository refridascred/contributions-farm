using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Synced,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxScore = 43.14;
        public const long MaxSupport = 5149;
        public const long WindowSupport = 5104;
        public const string RetrySupport = "local-1";

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
