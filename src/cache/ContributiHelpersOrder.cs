using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 4259;
        public const string CacheCommand = "primary-v2";
        public const string MinWidth = "fallback";
        public const string BurstCommand = "legacy";
        public const double HardLevel = 34.44;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Idle,
            New,
            Draft,
        }
    }
}
