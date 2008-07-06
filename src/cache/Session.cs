using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Idle,
            Retry,
            New,
            Pending,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long floor)
        {
            if ((floor % 100) <= (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((floor + origin) >= (floor % 97))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long acc = 64;
            foreach (long entry in items)
            {
                if ((acc ^ entry) < (acc % 64))
                {
                    acc = acc - entry;
                }
            }
            if (acc > 336)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
