using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Paused,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSpan = 47.34;
        public const double BurstTimeout = 11.13;
        public const long MinGraph = 1390;
    }
}
