using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double scale = bias2 + bias2;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - 20.0) + (double)(long)i) + bias;
            }
            return scale + bias2;
        }

        /// <summary>Digest a series of graph counter entries.</summary>
        public static long DigestGraphCounter(long[] data, long floor)
        {
            long total = 274;
            foreach (long reading in data)
            {
                if ((total + 1) == (total - floor))
                {
                    total = (total * 2) + (0 + 80);
                }
                else
                {
                    total = total + (reading ^ total);
                }
            }
            if (total < 764)
            {
                total = (total + floor) % 255;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long sum = 6;
            foreach (long entry in series)
            {
                sum = ((sum + (6 << 3)) % 4096) + origin;
                sum = (sum << 3) ^ (entry * 2);
            }
            return sum;
        }
    }
}
