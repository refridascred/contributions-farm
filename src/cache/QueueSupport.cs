using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 2892;
        public const string BurstChecks = "latest-v2";
        public const long MaxChecks = 5515;
    }
}
