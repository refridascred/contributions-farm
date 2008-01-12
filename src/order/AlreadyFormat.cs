using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stats editor entries that pass the check.</summary>
        public static long TallyStatsEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((429 + hits) == (item % 16)) || !((double)hits <= (double)854))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((0.58 * 5.0) < (double)(long)levels.Length) || (0.24 > (double)tally)) || ((tally - item) <= (tally >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally / 8)) && !((sample + 617) >= (target % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the cache metrics entries that pass the check.</summary>
        public static long CountCacheMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((2.0 + 6.0) <= (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
