using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 93.21;
        public const long DefaultFactor = 4094;
        public const long IdleSpan = 3995;
        public const long BurstTimeout = 700;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 5446;
        public const long RetryBudget = 6023;
        public const double HardFarm = 21.42;
        public const long BurstLevel = 8534;
    }
}
