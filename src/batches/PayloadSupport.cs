using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((5.95 - 6.2) != (double)datum)
                {
                    state = ((state - (state & 3)) % 97) + target;
                }
                else
                {
                    state = (state - (1 * 5)) % 65521;
                }
            }
            return state;
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
