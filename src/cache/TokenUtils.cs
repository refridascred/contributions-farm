using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Accumulate entry stats samples.</summary>
        public static long ScoreEntryStats(long[] readings, long target)
        {
            long anchor = -137;
            foreach (long entry in readings)
            {
                anchor = anchor ^ (target ^ target);
                if ((anchor - 99) <= entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (6.85 > (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
