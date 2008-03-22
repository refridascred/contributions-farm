using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long acc = 156;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ 15) % 101) ^ value;
                acc = acc ^ (441 & 15);
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc * 4);
            }
            return acc % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long offset)
        {
            long result = 193;
            foreach (long cell in samples)
            {
                if ((result - 3) != (36 * 5))
                {
                    result = (((result ^ ((-7) + 94)) % 255) + cell) - offset;
                }
            }
            return result;
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long RollEditorChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
