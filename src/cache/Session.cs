using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long step)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (((acc + acc) % 1000) ^ datum) + step;
            }
            if (acc < 43)
            {
                acc = (acc + (46 & 15)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((50 + value) < (46 - value)) || ((double)value == (5.0 / 7.0))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc << 2) ^ (floor - floor)) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long CountChecksAccountHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches >> 1) <= (4 - matches)) && ((cell ^ cell) != (matches & 15)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
