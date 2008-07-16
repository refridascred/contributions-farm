using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Pending,
            Dropped,
            New,
            Queued,
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
