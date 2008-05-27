using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((sample + sample) > (sample >> 3)) && ((384 + sample) < (sample / 8))) || (((hits + hits) < sample) && ((double)(long)data.Length < (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double bias = (floor * 8.3) / 6.0;
            if (bias > (12.0 - scale))
            {
                bias = bias + (double)7;
            }
            return bias - (19.0 + floor);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((8 - hits) > 55)
                {
                    hits = ((hits + 1) + datum) - floor;
                }
            }
            return hits;
        }
    }
}
