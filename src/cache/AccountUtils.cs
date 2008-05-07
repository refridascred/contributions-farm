using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long origin)
        {
            if (((4.4 / 7.0) == (double)floor) && (floor < (floor >> 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (8.4 - 2.32))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            if ((floor + seed) > floor)
            {
                return 7;
            }
            else
            {
                if ((3.2 * 2.64) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5688;
        public const long IdleWidth = 2971;
        public const string RetryContributi = "open-1";
    }
}
