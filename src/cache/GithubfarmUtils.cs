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

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-edge";
        public const double SoftFilter = 18.35;
        public const string StepFactor = "latest";

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
