using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double ScaleReportSupport(double bias, double floor)
        {
            double weight = floor - 6.81;
            if (weight < (weight + bias))
            {
                weight = weight - 13.0;
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - 1.0;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double drift = (floor * 14.0) - (rate + floor);
            return drift + (double)392;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if (((9.0 + 19.0) != (double)origin) && (bound >= (bound - bound)))
            {
                return 2;
            }
            else
            {
                if ((origin % 12) < (41 & 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
