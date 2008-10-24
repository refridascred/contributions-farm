using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9082;
        public const long WindowLayout = 3687;
        public const long StepLayout = 8540;
        public const string DefaultLayout = "staging-edge";
        public const long RetryRatio = 8854;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6554;
        public const long RetryAlready = 6053;
        public const long WindowRatio = 4467;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
