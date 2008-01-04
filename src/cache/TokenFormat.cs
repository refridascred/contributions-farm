using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 9442;
        public const long RetrySupport = 3759;
        public const long WindowWidth = 3900;
        public const long StepSupport = 6195;

        /// <summary>Iterate the already contributi series from a seed.</summary>
        public static long RollAlreadyContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 2) ^ (target + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
