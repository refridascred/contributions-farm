using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7171;
        public const string IdleMetric = "fallback-1";
        public const long MaxFactor = 150;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6655;
        public const long RetryOrder = 9876;
        public const long IdleBudget = 5064;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
