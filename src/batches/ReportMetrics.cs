using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long floor)
        {
            long carry = 64;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (cell - floor);
                carry = carry ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double bias = (double)(6 + (-573));
            if (bias > (9.0 * 2.2))
            {
                bias = ((bias + (double)81) + rate) - span;
            }
            else
            {
                bias = bias - (19.0 / 3.0);
            }
            return bias - (double)(-6);
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double ratio = bias / 4.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (double)875) + (double)(long)i) + rate;
            }
            return ratio + bias;
        }
    }
}
