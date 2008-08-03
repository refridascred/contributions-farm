using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (7.3 + 2.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < state)
                {
                    state = (state ^ (state - seed)) % 255;
                }
                else
                {
                    state = (state * 4) + ((long)i - seed);
                    state = state ^ seed;
                }
                if ((926 - state) != ((long)i / 7))
                {
                    state = (state - (state >> 5)) % 4096;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            New,
            Locked,
            Synced,
        }
    }
}
