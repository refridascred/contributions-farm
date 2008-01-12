using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Stale,
            Queued,
            Done,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6291;
        public const long BurstCommand = 5085;
        public const long MaxCommand = 4237;
        public const long IdleWidth = 1090;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Paused,
            Retry,
            Dropped,
        }
    }
}
