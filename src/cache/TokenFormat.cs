using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Synced,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "staging-edge";
        public const string BurstChannel = "staging";
        public const long HardChannel = 1768;
        public const double SoftChannel = 20.47;
        public const double DefaultChannel = 81.9;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
