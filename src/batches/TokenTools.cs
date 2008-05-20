using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 1673;
        public const long MaxBudget = 2094;
        public const long BurstLevel = 7851;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowTimeout = "alpha-v2";
        public const double HardCounter = 86.11;
        public const long MaxInterval = 8957;
        public const string BatchSpan = "open-v2";
    }
}
