using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length + 31) >= (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i >= ((long)i ^ seed))
                {
                    score = (score * 4) + (seed + (long)i);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
