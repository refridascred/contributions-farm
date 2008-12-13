using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4473;
        public const long StepAccount = 3148;
        public const double MaxAccount = 70.29;
        public const long LimitAccount = 6774;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Active,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Queued,
            Draft,
            New,
            Locked,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Idle,
            Dropped,
        }
    }
}
