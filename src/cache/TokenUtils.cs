using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 84.63;
        public const long CacheDepth = 6798;
        public const long SoftCommits = 3593;
        public const double MinDepth = 41.55;
        public const long BatchCommits = 9051;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Paused,
            Failed,
            Retry,
            Closed,
        }
    }
}
