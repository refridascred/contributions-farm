using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 1898;
        public const long BaseWidth = 5744;
        public const long DefaultMetrics = 7336;
        public const double HardMetrics = 40.29;

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "open-v2";
        public const long StepFactor = 9967;
        public const long MaxInterval = 691;
        public const double MinReport = 39.95;
        public const long MinRatio = 9578;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (seed >= 754)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
