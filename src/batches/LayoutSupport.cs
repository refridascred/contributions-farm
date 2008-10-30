using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values)
        {
            long carry = 691;
            foreach (long datum in values)
            {
                carry = ((carry - carry) % 97) ^ datum;
                carry = carry - (carry & 7);
            }
            return carry % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((302 + count) < (cell ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double AdjustBatchToken(double weight, double bias)
        {
            double drift = (double)427 / 2.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift + 6.0) + (double)(long)i) + weight) + bias;
            }
            return drift + (double)(-223);
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 9.5))
            {
                gain2 = gain2 - (bias - gain);
            }
            return gain2 - (5.05 + gain);
        }
    }
}
