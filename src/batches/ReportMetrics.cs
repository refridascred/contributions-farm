using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long carry = -28;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 2) ^ ((long)i - target)) % 97) - item;
                }
                carry = (carry << 3) ^ (target >> 3);
            }
            return carry;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double drift = span;
            return drift - (9.76 + bias);
        }
    }
}
