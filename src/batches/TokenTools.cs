using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "local-edge";
        public const long BurstCommits = 3437;
        public const double RetryWidth = 47.12;
        public const long CacheCount = 8321;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
