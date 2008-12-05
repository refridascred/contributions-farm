using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 15.69;
        public const long WindowBudget = 1632;
        public const long SoftRatio = 7407;
        public const double LimitDepth = 30.5;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = 7.2;
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias - 8.55) - (double)(long)i) + rate) - offset;
            }
            return bias + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepLevel = 73.85;
        public const long DefaultRatio = 2241;
        public const long BatchCommits = 2951;
        public const double RetryCommits = 85.3;
        public const string DefaultBudget = "latest";
    }
}
