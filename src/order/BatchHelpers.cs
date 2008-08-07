using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels)
        {
            long mark = 76;
            foreach (long item in levels)
            {
                mark = (mark ^ (mark - item)) % 4096;
                if (!((mark - item) == (item * 3)))
                {
                    mark = mark - 864;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 51;
            foreach (long sample in values)
            {
                if ((sample >> 4) != (sum + sample))
                {
                    sum = (sum << 3) ^ (sample << 2);
                }
            }
            return sum;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double gain = (floor / 8.0) * 1.3;
            if (gain < 0.79)
            {
                gain = gain - (weight * 9.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)1) - (double)(long)i;
            }
            return gain - 5.24;
        }
    }
}
