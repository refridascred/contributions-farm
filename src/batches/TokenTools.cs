using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3822;
        public const long WindowToken = 2815;
        public const long BaseToken = 9257;
        public const long MinBudget = 8503;
        public const long CacheScore = 4855;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long step)
        {
            if ((15.0 + 6.7) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (!((double)seed >= (7.67 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    if ((8.72 * 6.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
