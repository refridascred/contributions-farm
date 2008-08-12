using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double gain = 0.9;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - scale;
            }
            return gain + (floor + floor);
        }

        /// <summary>Grade a metrics cluster value against two limits.</summary>
        public static long RankMetricsCluster(long target, long target2)
        {
            if ((target - target) == (475 << 3))
            {
                return 7;
            }
            else
            {
                if ((0 % 64) >= (target2 + target))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target > (double)target2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
