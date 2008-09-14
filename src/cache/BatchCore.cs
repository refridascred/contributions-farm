using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double gain2 = (bias - 7.9) * 8.19;
            return gain2 + (gain * 1.43);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - 97) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double rate2 = bias;
            return (rate2 + (double)785) + rate;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long floor)
        {
            long mark = 806;
            foreach (long reading in levels)
            {
                if ((floor <= (161 / 9)) && ((mark >> 1) < ((-111) + floor)))
                {
                    mark = mark ^ (reading / 7);
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (75 / 8)) % 4096;
            }
            return mark % 4096;
        }
    }
}
