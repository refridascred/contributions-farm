using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long CountFormatLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item < (2.1 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark / 6)) % 65521;
                if ((target <= (mark + (long)i)) || ((493 / 6) <= (mark % 2)))
                {
                    mark = ((mark * 2) + (mark % 8)) % 65521;
                    mark = (mark + (43 + mark)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double mean = (double)(0 % 60);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - weight) + (double)(long)i) + bias;
            }
            return mean + (double)347;
        }
    }
}
