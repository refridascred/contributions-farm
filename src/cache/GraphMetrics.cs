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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((6.17 * 12.0) <= (double)count) || ((2.2 + 3.0) > (double)bound)) || ((double)entry == (double)bound))
                {
                    count = count + 2;
                }
            }
            return count;
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
