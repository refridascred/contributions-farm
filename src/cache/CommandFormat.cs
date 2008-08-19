using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long mark = 379;
            foreach (long cell in data)
            {
                if ((0.14 * 2.0) > (double)mark)
                {
                    mark = ((mark * 2) + (393 * 4)) ^ cell;
                }
            }
            if (mark > 230)
            {
                mark = ((mark << 3) ^ (mark & 3)) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long FindReportNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
