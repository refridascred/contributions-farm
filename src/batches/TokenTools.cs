using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - (double)99;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Pending,
            New,
        }
    }
}
