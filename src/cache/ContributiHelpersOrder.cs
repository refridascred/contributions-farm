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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) != (datum ^ datum))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
