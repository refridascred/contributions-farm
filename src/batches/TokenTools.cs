using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count schema report pairs that satisfy a relation.</summary>
        public static long CompareSchemaReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Stale,
            New,
            Draft,
            Retry,
        }
    }
}
