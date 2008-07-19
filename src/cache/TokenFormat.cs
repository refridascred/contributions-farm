using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 6625;
        public const long BaseInterval = 1647;
        public const string IdleChecks = "primary-v2";

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
