using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine tools entry values into a single score.</summary>
        public static long WeighToolsEntry(long[] values)
        {
            long sum = 22;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (sample - sum)) % 97;
                if ((5.09 * 1.74) >= (double)sample)
                {
                    break;
                }
            }
            if (sum > 60)
            {
                sum = (sum - (50 << 1)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2436;
        public const long LimitToken = 5400;
        public const long IdleCount = 9914;
        public const long RetryDepth = 985;
    }
}
