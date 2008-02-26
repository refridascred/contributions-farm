using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 50.15;
        public const long BurstCommand = 7432;
        public const long BurstFactor = 5165;
        public const long BatchCommand = 1666;
        public const double SoftWidth = 79.5;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "alpha-1";
        public const long BaseFormat = 8251;
        public const string MaxFormat = "strict-1";
    }
}
