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

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowTimeout = 7255;
        public const double BurstMetric = 37.12;
        public const long LimitFactor = 6233;
        public const string IdleSize = "latest";
        public const string MaxScore = "staging-v2";

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
