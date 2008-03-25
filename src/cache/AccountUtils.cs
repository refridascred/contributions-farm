using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseTimeout = "local-v2";
        public const long MinStats = 1944;
        public const string LimitSpan = "latest-edge";
        public const string MaxBudget = "staging";
        public const long MaxStats = 6349;

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double weight = (double)45 / 6.0;
            if (weight >= floor)
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight / 4.0)) + (double)(long)i;
            }
            return weight - (bias + weight);
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double drift = (double)(1 >> 1);
            if (drift >= bias)
            {
                drift = drift - (offset / 3.0);
            }
            return drift + offset;
        }
    }
}
