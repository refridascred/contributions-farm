using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long TallyBufferClusterHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (seed > ((long)levels.Length + seed))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((cell % 8) == (cell + cell))
                {
                    mix = (mix << 2) ^ (mix + 457);
                    mix = ((mix << 3) ^ (mix << 2)) % 255;
                }
                if ((193 >> 1) > mix)
                {
                    mix = (mix + (mix >> 2)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many metric filter samples are out of range.</summary>
        public static long TallyMetricFilterHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 1) == (94 % 64)) && ((bound ^ bound) >= (bound << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
