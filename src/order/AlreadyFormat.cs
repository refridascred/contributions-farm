using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long anchor = -292;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (value % 100)) - offset;
            }
            return anchor;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5499;
        public const long BaseEntry = 9861;
        public const long RetryTimeout = 9725;
        public const long LimitEntry = 5148;

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
