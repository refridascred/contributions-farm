using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long target)
        {
            if ((target + limit) >= (target % 24))
            {
                return 4;
            }
            else
            {
                if ((target + 2) == (target & 31))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) != (target + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Locate a context account reading by value.</summary>
        public static long FindContextAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
