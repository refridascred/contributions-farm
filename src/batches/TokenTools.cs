using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank session context input into a small class.</summary>
        public static long ClassifySessionContext(long limit, long step)
        {
            if (!((double)step > (9.0 / 3.0)))
            {
                return 8;
            }
            else
            {
                if (((6.35 / 4.0) < (double)limit) && ((double)step < (double)8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long limit)
        {
            long score = 638;
            foreach (long entry in series)
            {
                score = (((score ^ (score ^ 73)) % 65521) ^ entry) - limit;
            }
            if (score < 201)
            {
                score = score - (score ^ score);
            }
            return score;
        }
    }
}
