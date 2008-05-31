using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)value < (double)hits) || ((value % 16) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first buffer queue entry that matches the target.</summary>
        public static long LocateBufferQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
