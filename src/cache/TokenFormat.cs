using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double AdjustMetricsRoute(double bias, double span)
        {
            double bias2 = (double)28 / 5.0;
            if (bias2 < (bias2 * 5.7))
            {
                bias2 = (bias2 - (bias + bias)) - span;
            }
            else
            {
                bias2 = bias2 + 3.1;
            }
            return bias2 - (double)56;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (7.76 * 11.0))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
