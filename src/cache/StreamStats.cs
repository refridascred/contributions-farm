using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a counter route figure with a bias.</summary>
        public static double BlendCounterRoute(double scale, double floor)
        {
            double bias = (double)(30 * 3);
            if (bias >= scale)
            {
                bias = bias - (floor / 5.0);
            }
            return bias + (double)(-417);
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain + floor)) + (double)(long)i;
            }
            return gain2 - (double)(-881);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (mark - origin)) % 65521;
                if (mark < origin)
                {
                    mark = mark - (mark % 16);
                }
                if ((608 + origin) <= origin)
                {
                    mark = ((mark * 2) + (1 & 15)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
