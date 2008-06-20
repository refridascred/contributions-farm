using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double weight = 3.36 / 2.0;
            if (weight < floor)
            {
                weight = weight - (5.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (0.25 - rate)) + (double)(long)i;
            }
            return weight - (rate * 9.7);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 8857;
        public const long RetryInterval = 3451;
        public const double MaxScore = 22.73;
        public const long LimitDepth = 8221;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseTimeout = 18.52;
        public const long RetryScore = 4339;
        public const long SoftBudget = 7522;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
