using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum - (sum + (long)i2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
