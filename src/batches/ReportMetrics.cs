using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSpan = 9389;
        public const string StepMetric = "cached-edge";
        public const long RetryMetric = 4720;
        public const double CacheMetric = 89.23;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }
    }
}
