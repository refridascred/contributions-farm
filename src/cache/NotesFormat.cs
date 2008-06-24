using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long MeasureToolsBufferGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((717 + 88) <= (value >> 2))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc << 3) ^ ((-21) * 5)) ^ (long)i2;
                    acc = ((acc * 2) + (7 << 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
