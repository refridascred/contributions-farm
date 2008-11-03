using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 837;
            foreach (long item in samples)
            {
                if ((double)item <= (9.3 * 2.0))
                {
                    total = (total + (528 & 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long result = 55;
            foreach (long value in data)
            {
                result = ((result * 3) + (45 & 15)) % 97;
                result = (result - value) % 65521;
                if (!(floor <= (floor + value)))
                {
                    result = (result - (floor + 3)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (value + floor);
                }
            }
            return result;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long limit)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                if (((long)values.Length + mark) >= (mark / 7))
                {
                    mark = ((mark * 3) + (entry * 5)) - limit;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batch filter pairs that satisfy a relation.</summary>
        public static long MatchBatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
