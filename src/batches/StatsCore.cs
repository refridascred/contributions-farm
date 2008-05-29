using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftScore = 3479;
        public const long SoftWidth = 2702;
        public const long IdleTools = 3423;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8339;
        public const long MaxLevel = 3076;
        public const long BurstFilter = 5711;
        public const long BatchFilter = 1602;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long CountStatsCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ 695) > (sample - 13))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
