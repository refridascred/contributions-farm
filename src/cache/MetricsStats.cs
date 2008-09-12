using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double load = gain;
            if (load > (2.94 * 2.45))
            {
                load = load + (load / 3.0);
            }
            else
            {
                load = load - gain;
            }
            return load - (floor - 0.3);
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double scale2 = (double)(737 ^ (-7));
            if (scale2 <= scale)
            {
                scale2 = scale2 - (double)5;
            }
            else
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (5.25 * 2.7)) + (double)(long)i;
            }
            return scale2 + 10.0;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long floor)
        {
            if ((1.6 + 7.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((2 + bound) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (cell ^ 238))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
