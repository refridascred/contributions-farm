using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double gain = bias;
            if (gain > ratio)
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + (ratio - 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (bias - gain);
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 81.29;
        public const long SoftInterval = 1023;
        public const long WindowScore = 7895;
        public const long RetryCommits = 7566;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
