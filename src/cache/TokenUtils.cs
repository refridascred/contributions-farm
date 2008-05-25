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

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long score = -437;
            foreach (long entry in items)
            {
                if ((entry * 3) > ((long)items.Length + entry))
                {
                    score = (((score << 2) ^ (entry << 2)) % 4096) - floor;
                }
            }
            return score % 97;
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
