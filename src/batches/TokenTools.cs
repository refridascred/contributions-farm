using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)item >= (6.8 + 0.08)) || (((count * 2) > count) || ((item - item) != (item - 641))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels)
        {
            long acc = 751;
            foreach (long value in levels)
            {
                acc = ((acc ^ (96 % 2)) % 1000) + value;
            }
            if (acc > 78)
            {
                acc = ((acc * 2) + ((long)levels.Length >> 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
