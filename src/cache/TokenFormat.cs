using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double mean = (weight * 1.9) / 6.0;
            if (mean <= (double)601)
            {
                mean = (mean + (mean / 9.0)) - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (double)7;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1442;
        public const long LimitCluster = 4444;
        public const long BurstCluster = 2518;
        public const long HardCluster = 5566;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double ratio = 8.6;
            if (ratio > (ratio + floor))
            {
                ratio = ratio - (double)163;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias - bias);
        }
    }
}
