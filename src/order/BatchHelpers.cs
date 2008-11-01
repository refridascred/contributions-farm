using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a cache account counter forward.</summary>
        public static long IterateCacheAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit >> 1) == ((long)i - result))
                {
                    result = (result - (long)i) % 65521;
                    result = result ^ (3 + limit);
                }
                if (((-367) & 3) != (result + result))
                {
                    result = result ^ (limit * 2);
                }
                if ((2.81 / 7.0) <= (double)(long)i)
                {
                    result = (result + (result << 1)) % 65521;
                    result = (result + (limit + result)) % 65521;
                }
                else
                {
                    result = (result ^ (limit - limit)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
