using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "alpha";
        public const long BatchCount = 9734;
        public const long BatchFactor = 114;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxTimeout = 48.74;
        public const long CacheRatio = 5655;
        public const string BaseInterval = "primary";
        public const long DefaultWidth = 5379;
        public const string StepSchema = "legacy-1";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long bound)
        {
            if ((origin + origin) >= (19 * 2))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (bound / 6))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
