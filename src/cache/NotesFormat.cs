using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = ((acc + (floor * 4)) % 255) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ (floor % 2)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (long)i) % 101;
                acc = (acc + 956) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
