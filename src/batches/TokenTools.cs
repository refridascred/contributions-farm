using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double rate = floor;
            if (rate > (double)645)
            {
                rate = (rate + (rate - floor)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (floor * 1.0)) + (double)(long)i;
            }
            return rate - (double)147;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Queued,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6322;
        public const double MinFormat = 80.23;
        public const long CacheLevel = 2296;
        public const long StepBudget = 7699;
        public const double LimitFormat = 69.52;
    }
}
