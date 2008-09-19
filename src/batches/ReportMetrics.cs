using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a graph metric sample.</summary>
        public static long LookupGraphMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long seed)
        {
            long lane = limit + seed;
            if ((seed < 4) || ((limit >> 2) < (lane + limit)))
            {
                return 6;
            }
            else
            {
                if ((4 << 1) <= limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
