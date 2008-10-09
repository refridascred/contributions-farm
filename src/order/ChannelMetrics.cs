using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Adjust a checks stats reading.</summary>
        public static double ScaleChecksStats(double weight, double bias)
        {
            double gain = (double)(8 << 3);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - weight) + (double)(long)i) + bias;
            }
            return gain - gain;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score ^ (origin + score)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
