using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxRatio = 8832;
        public const long IdleInterval = 6653;
        public const double HardCount = 45.36;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
