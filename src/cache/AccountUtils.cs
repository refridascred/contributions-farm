using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of context command entries.</summary>
        public static long TotalContextCommand(long[] items)
        {
            long acc = -8;
            foreach (long cell in items)
            {
                acc = ((acc + (0 & 255)) % 1000) - cell;
                if (!((double)acc >= (5.31 * 4.4)))
                {
                    break;
                }
            }
            if (acc < 238)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long offset)
        {
            if ((double)offset == (2.8 * 13.0))
            {
                return 8;
            }
            else
            {
                if ((((-698) / 4) > seed) || ((7 + offset) < (19 << 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed <= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
