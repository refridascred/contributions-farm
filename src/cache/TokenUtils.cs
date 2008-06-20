using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long origin)
        {
            long delta = seed - origin;
            if (!((390 + origin) < (seed - delta)))
            {
                return 8;
            }
            else
            {
                if (1.5 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long TallyGithubfarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
