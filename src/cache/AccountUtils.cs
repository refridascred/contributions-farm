using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 8617;
        public const double BatchStream = 11.61;
        public const long BurstStream = 4619;
        public const long RetryStream = 7050;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6874;
        public const long MinFarm = 9533;
        public const long RetrySize = 7362;
        public const long HardFarm = 4065;
    }
}
