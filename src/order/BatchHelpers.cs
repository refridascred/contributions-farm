using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 9402;
        public const double StepWidth = 80.46;
        public const double MinInterval = 63.59;
    }
}
