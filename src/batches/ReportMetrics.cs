using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long score = 921;
            foreach (long reading in levels)
            {
                if ((23 + offset) == (score * 5))
                {
                    score = ((score - (offset & 1)) % 65521) + reading;
                }
            }
            return score;
        }
    }
}
