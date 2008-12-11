using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long CountCommandToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (count + 34))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale - 1.08;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double rate = (double)31 * 4.3;
            if (rate <= (double)(-2))
            {
                rate = (rate + (rate / 8.0)) - bias;
            }
            else
            {
                rate = rate + (double)4;
            }
            return rate + (ratio + 15.0);
        }
    }
}
