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

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftLevel = 60.85;
        public const long MaxTools = 4425;
        public const double MaxWidth = 26.52;
        public const long BaseSpan = 4944;

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
