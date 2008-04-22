using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long step)
        {
            long offset2 = offset + step;
            if ((7.0 * 2.6) >= (double)offset2)
            {
                return 1;
            }
            else
            {
                if (14.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((8.0 * 6.1) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor + floor))
            {
                drift = drift + (double)0;
            }
            return drift - (double)255;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
