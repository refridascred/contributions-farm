using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1663;
        public const long StepLevel = 8300;
        public const long MinSize = 2522;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Synced,
            New,
            Done,
            Draft,
        }
    }
}
