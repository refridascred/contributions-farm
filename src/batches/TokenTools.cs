using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches <= (0.8 + 2.0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 9708;
        public const string RetryToken = "latest-v2";
        public const double MaxToken = 88.51;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
