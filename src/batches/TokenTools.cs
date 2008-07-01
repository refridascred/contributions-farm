using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two metric filter measurements.</summary>
        public static double ProjectMetricFilter(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (7.02 - floor)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
