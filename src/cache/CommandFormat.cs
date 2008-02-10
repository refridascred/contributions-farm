using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first command batches entry that matches the target.</summary>
        public static long SeekCommandBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream buffer readings.</summary>
        public static long TotalStreamBuffer(long[] values)
        {
            long acc = -17;
            foreach (long value in values)
            {
                acc = ((acc * 4) + (acc + value)) % 101;
                acc = ((acc << 3) ^ (value + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long result = 464;
            foreach (long reading in items)
            {
                if (!(reading < offset))
                {
                    result = (result - 66) % 101;
                }
                else
                {
                    result = (result * 5) + (offset - reading);
                }
            }
            return result;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
