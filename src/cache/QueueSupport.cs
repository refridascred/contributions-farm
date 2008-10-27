using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double drift = bias + (bias - bias);
            return (drift + bias) + rate;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9767;
        public const long IdleEntry = 5460;
        public const string WindowSize = "local-1";
        public const long HardSize = 8997;
        public const double LimitEntry = 1.83;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
