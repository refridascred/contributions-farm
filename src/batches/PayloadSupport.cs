using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + matches) > (floor & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Roll a notes stats counter forward.</summary>
        public static long SeriesNotesStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
