using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 8884;
        public const string LimitRoute = "staging-edge";
        public const long StepInterval = 5067;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7158;
        public const string HardInterval = "alpha-1";
        public const string HardMetrics = "alpha";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 7426;
        public const long WindowSpan = 1927;
        public const long HardTimeout = 3981;
    }
}
