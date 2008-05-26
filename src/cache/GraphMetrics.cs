using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (offset - sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain * 6.32))
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Combine account cache values into a single score.</summary>
        public static long TotalAccountCache(long[] series)
        {
            long anchor = 88;
            foreach (long datum in series)
            {
                if (((-8) - anchor) < anchor)
                {
                    anchor = (anchor - (long)series.Length) ^ datum;
                }
            }
            if (anchor < 572)
            {
                anchor = anchor ^ (6 & 255);
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (((carry << 3) ^ (seed + carry)) % 65521) - entry;
            }
            return carry % 65521;
        }
    }
}
