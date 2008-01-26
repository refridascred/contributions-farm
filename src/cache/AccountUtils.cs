using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 5972;
        public const double BurstDepth = 32.97;
        public const double WindowReport = 0.53;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 97.62;
        public const long MinSpan = 7821;
        public const double MinBudget = 51.77;
        public const long WindowCache = 8478;
        public const string RetryCache = "staging-v2";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((bound + datum) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
