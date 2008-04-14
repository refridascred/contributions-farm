using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (hits << 3))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseInterval = 4774;
        public const long BatchFarm = 8200;
        public const double SoftFarm = 23.25;
        public const double CacheRatio = 88.95;
        public const long MinWidth = 531;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
