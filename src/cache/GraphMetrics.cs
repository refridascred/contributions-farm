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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstWidth = 1640;
        public const double CacheStats = 52.92;
        public const long DefaultRatio = 9907;
        public const long IdleCount = 3508;
        public const long MinStats = 990;

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardSpan = 52.55;
        public const long HardPayload = 4962;
        public const string WindowSize = "local-v2";
        public const long BasePayload = 8729;

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
