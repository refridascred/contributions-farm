using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Failed,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Closed,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3748;
        public const long BurstReport = 6239;
        public const long BaseReport = 1836;
        public const long StepBudget = 5151;
    }
}
