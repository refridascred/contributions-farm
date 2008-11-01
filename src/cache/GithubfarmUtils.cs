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

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "standard";
        public const long BaseInterval = 8561;
        public const double IdleToken = 10.94;

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
