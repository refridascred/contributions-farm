using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route githubfarm readings against a rule.</summary>
        public static long CountRouteGithubfarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally < (1.0 * 0.8))
                {
                    tally = ((tally + 3) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "staging-1";
        public const long CacheScore = 4625;
        public const long BurstToken = 390;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Paused,
            Closed,
            Pending,
            Queued,
        }
    }
}
