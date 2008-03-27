using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batch farm samples.</summary>
        public static long TotalBatchFarm(long[] items, long offset)
        {
            long mark = 8;
            foreach (long cell in items)
            {
                if (((mark % 10) > mark) && ((cell >> 5) <= mark))
                {
                    mark = (((mark * 5) + (495 << 1)) % 65521) - offset;
                }
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
