using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultTimeout = 71.4;
        public const long SoftFactor = 917;
        public const double RetryCount = 97.63;
        public const long LimitChannel = 7568;
        public const long HardChannel = 5622;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Done,
        }
    }
}
