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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)limit != (2.0 / 6.0))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
