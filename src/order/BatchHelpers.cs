using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count <= (1 & 63))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
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
