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

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
