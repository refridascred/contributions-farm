using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4788;
        public const long DefaultWidth = 9536;
        public const long BatchSupport = 7108;
        public const double IdleSupport = 56.39;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (rate - 1.7);
        }
    }
}
