using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Pending,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)floor == (double)150)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 127) < 329)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
