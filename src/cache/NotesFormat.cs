using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the graph format series from a seed.</summary>
        public static long RollGraphFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc <= 0.33)
                {
                    acc = ((acc * 4) + (2 + step)) % 97;
                    acc = ((acc << 3) ^ (acc / 7)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
