using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first notes tools entry that matches the target.</summary>
        public static long FindNotesToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1765;
        public const double DefaultEditor = 74.46;
        public const long IdleCount = 1258;
        public const long BatchInterval = 8270;
        public const double CacheSize = 31.19;

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            if ((double)offset == (3.06 / 9.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (6.9 - 1.4)) && (origin < (offset + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((offset > origin) && ((offset ^ 972) < (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
