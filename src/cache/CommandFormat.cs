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

        /// <summary>Rank batches buffer input into a small class.</summary>
        public static long BucketBatchesBuffer(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((double)step > (double)bound)
            {
                return 3;
            }
            else
            {
                if (((692 + bound) <= step) && ((step ^ bound) >= (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
