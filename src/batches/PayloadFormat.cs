using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long target)
        {
            long anchor = 15;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + 537) ^ reading) + target;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
