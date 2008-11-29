using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const long HardContributi = 9429;
        public const long HardRatio = 3382;
        public const long WindowContributi = 2882;
        public const double LimitContributi = 95.2;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Queued,
            New,
        }
    }
}
