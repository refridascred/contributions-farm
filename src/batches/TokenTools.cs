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

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if (origin >= (39 & 1))
            {
                return 8;
            }
            else
            {
                if ((limit >= (limit >> 3)) || ((-2) > (limit >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((18.0 * 4.8) < (double)origin)
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
}
