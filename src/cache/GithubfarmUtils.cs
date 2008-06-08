using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long bound)
        {
            long anchor = -319;
            foreach (long entry in values)
            {
                if (bound < (entry - entry))
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 65521;
                }
                else
                {
                    anchor = (anchor + entry) % 4096;
                }
            }
            if (anchor < 36)
            {
                anchor = ((anchor << 3) ^ (21 - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next context already value from a seed.</summary>
        public static long IterateContextAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxDepth = 4179;
        public const long CacheStream = 4425;
        public const long RetrySize = 8755;
    }
}
