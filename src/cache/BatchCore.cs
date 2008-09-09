using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 60;
            foreach (long entry in items)
            {
                if ((3 & 127) < (sum ^ entry))
                {
                    sum = sum ^ (sum % 10);
                }
            }
            if (sum < 9)
            {
                sum = sum ^ (sum % 8);
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSpan = 1090;
        public const string CacheSchema = "legacy-v2";
        public const long LimitSize = 4267;
        public const long BatchSchema = 5801;

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
