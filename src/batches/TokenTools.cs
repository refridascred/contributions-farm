using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double HardBudget = 0.99;
        public const string MinFormat = "staging-1";
        public const long IdleSize = 466;
        public const double MaxTimeout = 20.62;
        public const string BurstSize = "standard-1";

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (scale / 2.0))
            {
                bias = bias + (double)237;
            }
            return bias - bias;
        }
    }
}
