using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long limit)
        {
            long acc = 71;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ sample) % 101;
                acc = ((acc * 2) + (284 ^ limit)) % 1000;
                if (!((long)levels.Length > (limit * 2)))
                {
                    acc = ((acc * 2) + limit) % 101;
                }
            }
            if (acc < 48)
            {
                acc = (acc + limit) % 101;
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
