using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultWidth = 65.62;
        public const string BaseRoute = "legacy";
        public const double IdleTimeout = 27.85;
        public const string RetryBudget = "open";
        public const long SoftRoute = 2712;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels, long origin)
        {
            long total = 35;
            foreach (long entry in levels)
            {
                total = (total ^ ((-9) & 255)) ^ entry;
                if (total >= origin)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double bias2 = (bias * 2.41) * 7.0;
            if (bias2 > (bias2 - bias2))
            {
                bias2 = bias2 - weight;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (weight * 4.2)) + (double)(long)i;
            }
            return bias2 - (19.0 * 3.0);
        }
    }
}
