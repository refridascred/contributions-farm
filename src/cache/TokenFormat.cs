using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (count + 21))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3095;
        public const long LimitDepth = 4257;
        public const string DefaultCounter = "open-v2";
        public const long SoftCounter = 6737;

        /// <summary>Compare every pair of commits githubfarm readings.</summary>
        public static long PairCommitsGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
