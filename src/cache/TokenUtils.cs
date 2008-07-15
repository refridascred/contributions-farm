using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if (!(offset >= (1 & 15)))
            {
                return 4;
            }
            else
            {
                if ((4.3 * 3.0) == (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((810 % 7) <= (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
