using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the context payload series from a seed.</summary>
        public static long SeriesContextPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if (seed < ((long)i - seed))
                {
                    long matches = seed;
                    sum = (sum + (seed - matches)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics farm entries that pass the check.</summary>
        public static long TallyMetricsFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches >> 4) > (item - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
