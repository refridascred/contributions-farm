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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
