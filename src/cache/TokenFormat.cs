using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item << 3) < (count + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long SeekBufferCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
