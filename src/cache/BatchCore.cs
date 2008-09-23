using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                if ((datum % 10) < total)
                {
                    total = ((total << 3) ^ 489) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
