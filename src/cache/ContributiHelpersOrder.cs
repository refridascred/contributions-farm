using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long DeriveGithubfarmCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((score - (long)i) >= (score / 9))
                {
                    score = score ^ (floor * 4);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinSpan = "staging";
        public const double WindowRoute = 92.59;
        public const long RetryRoute = 5218;
        public const long BaseRoute = 8943;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((seed ^ 1) < (hits / 7))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
