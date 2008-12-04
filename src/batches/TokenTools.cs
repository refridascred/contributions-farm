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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = mark ^ ((long)i2 ^ mark);
                }
                mark = mark ^ ((long)i - target);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
