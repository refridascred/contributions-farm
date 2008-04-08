using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((double)bound2 > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((4.8 - 0.3) != (double)bound2)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double rate2 = (bias * 7.5) - rate;
            return rate2 - rate;
        }

        /// <summary>Find the first session stats entry that matches the target.</summary>
        public static long LocateSessionStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
