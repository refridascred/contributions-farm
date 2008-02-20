using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = ((state + state) % 97) ^ datum;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits / 5) > (hits + step))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long SeriesStatsContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (((double)sum == (double)step) || ((step - step) >= (step >> 5)))
                {
                    sum = (sum ^ ((-525) + 9)) % 255;
                }
                if (!(81 <= step))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
