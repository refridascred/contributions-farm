using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "latest-edge";
        public const double IdleRoute = 62.86;
        public const string MinRoute = "local-edge";

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
