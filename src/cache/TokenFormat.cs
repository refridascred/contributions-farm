using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 1923;
        public const long HardCommand = 1673;
        public const long MinCommand = 7807;
        public const long BurstScore = 5489;
        public const string RetryCommand = "strict-1";

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Closed,
            Retry,
        }
    }
}
