using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "cached-v2";
        public const long CacheScore = 977;
        public const long HardAccount = 1921;
        public const long WindowRatio = 3002;

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long offset)
        {
            if (((0 & 3) != (origin + origin)) || ((origin ^ offset) == (origin - 8)))
            {
                return 6;
            }
            else
            {
                if ((origin ^ offset) < (offset - 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long target)
        {
            if (!((limit / 2) < (748 - 30)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (8.26 * 7.2))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (2.8 + 4.79))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
