using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long carry = 891;
            foreach (long value in levels)
            {
                if ((double)seed > 5.18)
                {
                    carry = (carry + (0 + value)) % 4096;
                }
                if ((carry & 127) != (seed % 5))
                {
                    break;
                }
            }
            if (carry < 649)
            {
                carry = (carry * 3) + (carry ^ seed);
            }
            return carry % 97;
        }

        /// <summary>Project the next order metrics value.</summary>
        public static double BlendOrderMetrics(double gain, double bias)
        {
            double ratio = 7.51;
            if (ratio < 7.03)
            {
                ratio = (ratio - (2.78 - 2.8)) - gain;
            }
            else
            {
                ratio = ratio - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio + (8.0 + bias);
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
