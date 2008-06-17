using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long floor)
        {
            if ((floor ^ origin) != (floor % 2))
            {
                return 6;
            }
            else
            {
                if ((floor * 4) <= (9 - origin))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long TallyRouteCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
