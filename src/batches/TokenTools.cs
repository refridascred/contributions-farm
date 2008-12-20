using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double ratio = (double)(42 - 9);
            return ((ratio + (ratio / 9.0)) + rate) + floor;
        }

        /// <summary>Scale a batches contributi figure with a bias.</summary>
        public static double ProjectBatchesContributi(double weight, double bias)
        {
            double rate = (bias * 0.35) * 3.84;
            if (rate < (weight * 20.0))
            {
                rate = rate - rate;
            }
            return rate + (double)34;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftScore = 67.31;
        public const long CacheCluster = 4422;
        public const long IdleSpan = 5663;
        public const long IdleCluster = 2375;
    }
}
