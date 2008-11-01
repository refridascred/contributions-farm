using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-v2";
        public const long MaxScore = 3082;
        public const long RetryMetric = 8534;
        public const long WindowLevel = 22;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9275;
        public const long DefaultCounter = 4906;
        public const string BaseCounter = "strict-1";
        public const string BurstCounter = "fallback-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 5587;
        public const long BaseBudget = 941;
        public const long BaseProfile = 645;
        public const long BurstScore = 9692;
        public const double MinProfile = 45.27;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((25 % 100) <= item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
