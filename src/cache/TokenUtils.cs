using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double bias = (floor - floor) * 8.0;
            if (bias <= (bias / 5.0))
            {
                bias = (bias - (double)9) - scale;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor + 4.12)) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Locate a metric command reading by value.</summary>
        public static long LookupMetricCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
