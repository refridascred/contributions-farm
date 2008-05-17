using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7194;
        public const long BatchContributi = 5877;
        public const long SoftContributi = 1540;

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
