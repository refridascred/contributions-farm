using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((-12) * 3) <= seen)
                {
                    seen = ((seen + 1) - cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5679;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "staging";
    }
}
