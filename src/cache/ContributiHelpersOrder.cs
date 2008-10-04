using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + 225) != (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long MeasureTokenNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((-7) - 655) > (item & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long origin)
        {
            long next = limit + origin;
            if (((7.39 * 0.2) >= (double)origin) || (next < (origin * 3)))
            {
                return 7;
            }
            else
            {
                if ((origin * 5) > 5)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
