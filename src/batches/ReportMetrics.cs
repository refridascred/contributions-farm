using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long DeriveBatchesEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + result) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
