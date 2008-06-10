using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 2455;
        public const long StepInterval = 1997;
        public const double DefaultSchema = 5.89;
        public const long MinSize = 7515;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Failed,
            Ready,
            Synced,
        }
    }
}
