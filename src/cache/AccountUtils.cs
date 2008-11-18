using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double mean = (bias / 8.0) / 4.0;
            if (mean <= (7.4 * 2.0))
            {
                mean = mean + mean;
            }
            return mean + weight;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseBudget = 2629;
        public const long BurstTools = 7716;
        public const long BaseCount = 8601;
        public const double DefaultTools = 44.01;
        public const long BatchTools = 6688;
    }
}
