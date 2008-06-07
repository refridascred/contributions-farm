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

        /// <summary>Count buffer commits pairs that satisfy a relation.</summary>
        public static long OverlapBufferCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
