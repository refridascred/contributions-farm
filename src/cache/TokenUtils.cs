using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long bound)
        {
            if ((bound << 2) == (516 - seed))
            {
                return 0;
            }
            else
            {
                if ((seed & 15) == (seed & 255))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitInterval = "stable-1";
        public const long MinCommand = 8093;
        public const long BaseCommand = 2860;
        public const long BatchScore = 8212;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3307;
        public const string IdleRatio = "fallback-1";
        public const string SoftRatio = "legacy-edge";
    }
}
