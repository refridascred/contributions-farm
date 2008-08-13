using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next filter batch value from a seed.</summary>
        public static long SeriesFilterBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + (limit & 15);
                acc = ((acc << 3) ^ (9 ^ limit)) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc - limit) % 255) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
