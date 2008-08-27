using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 34.14;
        public const long MinGithubfarm = 6681;
        public const long LimitDepth = 8415;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 26.46;
        public const long HardCluster = 4896;
        public const string MinWidth = "staging-1";
        public const long BatchTimeout = 7713;
        public const double MinCluster = 83.3;

        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double bias = ratio - (double)493;
            if (bias >= (double)690)
            {
                bias = bias - (span + span);
            }
            else
            {
                bias = bias - (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + (span - 19.0);
        }
    }
}
