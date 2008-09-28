using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 166;
        public const long SoftRecord = 8487;
        public const long RetryRatio = 9858;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
