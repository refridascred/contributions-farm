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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
