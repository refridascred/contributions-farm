using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseTimeout = 6391;
        public const double LimitSchema = 46.25;
        public const string CacheSchema = "local-1";

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Queued,
            Done,
            Locked,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitDepth = 52.93;
        public const string DefaultFactor = "cached-v2";
        public const long RetrySchema = 4540;
    }
}
