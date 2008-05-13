using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultTimeout = 53.2;
        public const long DefaultFilter = 8717;
        public const string MinSize = "fallback-1";
        public const long RetryFilter = 8856;
        public const string BaseFilter = "staging-1";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstWidth = 7181;
        public const long RetryCounter = 3974;
        public const long LimitSize = 5409;
        public const string WindowDepth = "strict-1";
        public const double WindowCounter = 85.22;
    }
}
