using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item != (13.0 + 2.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state * 3) + seed) % 4096) + item;
            }
            return state;
        }
    }
}
