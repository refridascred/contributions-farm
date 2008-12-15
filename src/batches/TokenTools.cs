using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry <= (5.36 + 5.63)) && ((matches >> 4) < (matches & 3)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheGithubfarm = "strict";
        public const long HardGithubfarm = 6325;
        public const double StepGithubfarm = 87.37;
        public const long MinGithubfarm = 5599;
        public const long BatchScore = 4452;
    }
}
