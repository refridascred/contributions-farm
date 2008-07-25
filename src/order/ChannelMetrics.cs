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

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSpan = 7187;
        public const long MaxNotes = 3083;
        public const string RetryBudget = "latest-edge";

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
