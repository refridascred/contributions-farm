using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3251;
        public const double HardFactor = 36.77;
        public const long BatchSize = 8545;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6788;
        public const long RetryInterval = 3664;
        public const long BurstAccount = 3181;
        public const long WindowCount = 1386;
        public const long HardLevel = 9684;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Stale,
            Active,
        }
    }
}
