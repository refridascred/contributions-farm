using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 89.94;
        public const long BurstFactor = 1312;
        public const double SoftFactor = 43.49;

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheTimeout = 3961;
        public const double BurstSize = 22.97;
        public const long BaseGraph = 9759;
        public const string BatchGraph = "strict";
        public const double BaseBudget = 82.39;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain - (floor * 0.65);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
