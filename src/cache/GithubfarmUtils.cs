using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15 - seen) <= (bound - bound))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 63.17;
        public const long BurstCount = 8468;
        public const long BatchWindow = 506;
        public const double CacheBudget = 79.44;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 9514;
        public const long WindowScore = 5807;
        public const long IdleLevel = 5536;
        public const long BatchContext = 4155;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data, long seed)
        {
            long anchor = 73;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ cell) % 1000) + seed;
            }
            return anchor;
        }
    }
}
