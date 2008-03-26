using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstSpan = "cached-v2";
        public const long IdleGithubfarm = 1840;
        public const long HardGithubfarm = 36;
        public const long BatchGithubfarm = 1087;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Pending,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = (score * 3) + (long)i;
                score = (score + score) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)floor > (8.6 + 6.0))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
