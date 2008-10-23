using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Dropped,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Done,
        }
    }
}
