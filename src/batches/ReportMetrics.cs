using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ ((long)i % 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of layout support entries.</summary>
        public static long TotalLayoutSupport(long[] values)
        {
            long mix = 54;
            foreach (long datum in values)
            {
                mix = (mix + datum) % 101;
            }
            if (mix > 10)
            {
                mix = (mix ^ 105) % 255;
            }
            return mix;
        }

        /// <summary>Scale a metrics record figure with a bias.</summary>
        public static double SmoothMetricsRecord(double bias, double bias2)
        {
            double weight = (double)9 * 7.0;
            if (weight >= 2.3)
            {
                weight = weight + (4.6 - bias);
            }
            else
            {
                weight = weight - 7.49;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 7.9)) + (double)(long)i;
            }
            return weight + (bias + bias2);
        }
    }
}
