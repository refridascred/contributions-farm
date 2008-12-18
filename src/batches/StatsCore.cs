using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels, long offset)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if ((offset % 60) <= total)
                {
                    total = (total ^ (-54)) ^ datum;
                }
                else
                {
                    total = (total ^ offset) % 4096;
                }
            }
            if (total > (-763))
            {
                total = ((total << 3) ^ (total >> 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 68.58;
        public const double MinProfile = 47.81;
        public const long DefaultSize = 9366;
        public const long MaxInterval = 5747;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Idle,
            Done,
        }
    }
}
