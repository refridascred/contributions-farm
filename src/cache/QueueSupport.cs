using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long MeasureChecksMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (3.8 * 15.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double rate2 = 2.0 - floor;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + floor) - (double)(long)i) + rate;
            }
            return rate2 + floor;
        }
    }
}
