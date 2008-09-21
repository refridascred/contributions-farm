using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 2818;
        public const double IdleOrder = 78.76;
        public const long MinOrder = 7955;

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "open";
        public const string BurstEditor = "primary-edge";
        public const long LimitRatio = 9481;
        public const long WindowEditor = 2801;
        public const string HardFactor = "staging-edge";
    }
}
