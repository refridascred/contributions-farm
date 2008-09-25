using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardLevel = "primary-v2";
        public const string BurstEntry = "staging-edge";
        public const long WindowEntry = 4682;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 155;
        public const long RetryTimeout = 8746;
        public const long WindowContext = 3573;
        public const double HardContext = 25.07;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
