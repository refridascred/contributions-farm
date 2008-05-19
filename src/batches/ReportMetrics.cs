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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
