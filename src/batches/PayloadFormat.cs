using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long target)
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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Queued,
            Done,
            Locked,
        }
    }
}
