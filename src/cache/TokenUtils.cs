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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long offset)
        {
            long next = step ^ offset;
            if ((next * 3) != ((-84) + 24))
            {
                return 8;
            }
            else
            {
                if ((step + 523) >= (step ^ offset))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

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
