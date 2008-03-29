using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double rate = (double)(407 ^ 253);
            if (rate >= (9.4 * 0.13))
            {
                rate = rate - (rate - offset);
            }
            return rate + (bias - 14.0);
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
