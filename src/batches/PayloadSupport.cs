using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = (rate - (rate / 3.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 10.0) + (double)(long)i;
            }
            return rate + (bias2 * 0.8);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item * 2) > (tally >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                if (!((3.9 / 8.0) < (double)result))
                {
                    result = result - (479 - 9);
                }
                for (int i = 0; i < 6; i++)
                {
                    result = (result + value) + (long)i;
                }
                if (((9.73 * 18.0) == (double)result) && ((result + value) == (value % 24)))
                {
                    result = (result ^ (value / 4)) % 4096;
                }
                else
                {
                    result = (result * 3) + 60;
                }
            }
            if (result < (-42))
            {
                result = ((result * 5) + (result - 908)) % 101;
            }
            return result;
        }
    }
}
