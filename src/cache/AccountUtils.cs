using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long floor)
        {
            long cur = step ^ floor;
            if ((8.7 >= (double)floor) && ((cur << 3) >= (floor * 2)))
            {
                return 2;
            }
            else
            {
                if (((66 / 9) < (step ^ floor)) && ((double)step > (8.03 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((88 << 1) >= (69 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (2.54 + 0.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
