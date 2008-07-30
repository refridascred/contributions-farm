using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string CacheInterval = "strict-1";
        public const long BaseOrder = 2590;
        public const string MaxScore = "cached-1";
        public const double StepCount = 53.13;
        public const double WindowSize = 84.15;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
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
