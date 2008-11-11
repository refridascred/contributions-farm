using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double bias = (double)42 - ratio;
            if (bias <= (ratio - 14.0))
            {
                bias = bias - (double)7;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (floor + floor)) + (double)(long)i;
            }
            return bias - (double)504;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((20 + count) != (8 / 3))
                {
                    count = ((count + 3) ^ value) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= (hits % 10))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long offset)
        {
            if ((offset % 8) > (seed % 24))
            {
                return 3;
            }
            else
            {
                if ((seed < (offset << 3)) && ((offset + seed) >= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
