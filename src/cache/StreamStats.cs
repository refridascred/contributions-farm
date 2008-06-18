using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a order channel counter forward.</summary>
        public static long SeriesOrderChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (anchor >= (2 % 64))
                {
                    anchor = ((anchor * 3) + (long)i) % 97;
                }
                else
                {
                    anchor = (anchor ^ (seed + (long)i)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = (double)(540 - 26);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.92)) - (double)(long)i) - rate) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long GradeOrderChannel(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((78 << 2) >= prev)
            {
                return 3;
            }
            else
            {
                if (prev <= (bound * 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
