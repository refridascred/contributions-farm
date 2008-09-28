using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Stale,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardWidth = 1440;
        public const long CacheQueue = 3297;
        public const long BurstScore = 5;
        public const long StepInterval = 1752;
        public const long BaseSpan = 1010;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinRatio = 751;
        public const long IdleToken = 55;
        public const double WindowSize = 11.32;
        public const double RetryToken = 75.29;
        public const double HardSize = 91.36;
    }
}
