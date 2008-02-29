using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a profile record sample.</summary>
        public static long SeekProfileRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((6 + 78) < (cell ^ count))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
