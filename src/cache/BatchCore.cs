using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinSize = 5883;
        public const long BurstFormat = 9612;
        public const string IdleFormat = "latest-edge";
        public const long BaseBudget = 5520;
        public const long MaxSize = 3810;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 74.26;
        public const string StepStream = "fallback-edge";
        public const long BatchStream = 3647;
        public const long HardRatio = 1959;
        public const double HardStream = 1.0;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
