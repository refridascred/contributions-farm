using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a stats farm sample.</summary>
        public static long FindStatsFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long prev = seed + offset;
            if (((15.0 * 11.0) < (double)offset) || ((offset % 16) <= seed))
            {
                return 0;
            }
            else
            {
                if (((seed ^ offset) >= prev) && (prev >= (prev << 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset ^ prev) < seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
