using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 432;
        public const long RetryBudget = 4030;
        public const long BaseDepth = 9070;
        public const long BaseStream = 7242;
        public const long HardStream = 5678;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
