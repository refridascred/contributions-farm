using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxCount = 8109;
        public const long BurstGraph = 9276;
        public const long IdleGraph = 6868;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7252;
        public const double BatchSchema = 29.59;
        public const long HardInterval = 6216;
    }
}
