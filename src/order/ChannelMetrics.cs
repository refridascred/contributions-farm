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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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
