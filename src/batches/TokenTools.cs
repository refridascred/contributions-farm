using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long floor)
        {
            long bound = offset + floor;
            if ((4.6 - 9.0) <= (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset < bound)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length + count) < 8) && ((count + 8) != (datum - datum)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally >> 1) < (tally * 5)) || (7.45 <= (double)datum))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
