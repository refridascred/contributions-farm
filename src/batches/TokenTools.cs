using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((224 + seed) == (origin % 12))
            {
                return 1;
            }
            else
            {
                if (origin < (seed << 3))
                {
                    return 8;
                }
                else
                {
                    if ((seed > (3 >> 1)) || ((seed * 4) == (gap >> 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const long StepAlready = 8773;
        public const double CacheInterval = 90.68;
        public const long DefaultDepth = 7011;
    }
}
