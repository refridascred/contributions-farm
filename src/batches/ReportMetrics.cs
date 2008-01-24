using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 4025;
        public const long StepContext = 7619;
        public const long HardContext = 5926;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Draft,
            Stale,
            Synced,
            Dropped,
        }
    }
}
