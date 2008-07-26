using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((6.07 / 8.0) != (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((step << 1) < (value * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double rate = bias * 7.13;
            return rate + (weight / 8.0);
        }

        /// <summary>Project the next notes account value.</summary>
        public static double ScaleNotesAccount(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > bias)
            {
                gain = gain - (bias - 14.0);
            }
            else
            {
                gain = gain + (bias2 * 9.6);
            }
            return gain - bias2;
        }
    }
}
