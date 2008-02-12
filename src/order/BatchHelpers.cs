using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total + (bound - bound);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
