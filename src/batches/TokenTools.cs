using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 3728;
        public const long BatchTools = 7247;
        public const long BurstSize = 1205;
        public const long DefaultLevel = 3276;
        public const long StepLevel = 5169;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
