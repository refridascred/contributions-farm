using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long step)
        {
            if ((double)393 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((step >> 4) != (offset + step))
                {
                    return 0;
                }
                else
                {
                    if ((offset + step) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheDepth = 5869;
        public const string CacheGithubfarm = "legacy-v2";
        public const long IdleGithubfarm = 777;

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long OverlapToolsCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
