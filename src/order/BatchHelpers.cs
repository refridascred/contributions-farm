using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches <= (matches & 7)) || ((5.0 + 9.7) != (double)datum)) && ((matches >= datum) && ((datum & 1) >= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
