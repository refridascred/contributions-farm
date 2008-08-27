using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Active,
            Synced,
            Dropped,
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
