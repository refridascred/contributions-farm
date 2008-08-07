using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long gap = seed - origin;
            if ((11.0 / 4.0) == (double)origin)
            {
                return 2;
            }
            else
            {
                if (((gap / 2) >= (origin - origin)) && (3 >= (gap / 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank entry commits input into a small class.</summary>
        public static long GradeEntryCommits(long offset, long limit)
        {
            long diff = offset + limit;
            if ((double)diff == (double)44)
            {
                return 8;
            }
            else
            {
                if ((double)4 > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (diff < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long floor)
        {
            if ((double)bound >= (1.5 * 7.75))
            {
                return 5;
            }
            else
            {
                if (!((bound + bound) == (bound / 6)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
