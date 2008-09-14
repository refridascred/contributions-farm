using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = span - (double)2;
            if (load <= (span - load))
            {
                load = (load - 3.59) - ratio;
            }
            else
            {
                load = load + (double)697;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
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
