using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BurstBudget = 23.23;
        public const string BatchSession = "primary-v2";
        public const double SoftTimeout = 30.1;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }
    }
}
