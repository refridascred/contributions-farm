using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if (!((877 % 100) <= (seed * 5)))
                {
                    mix = ((mix * 2) + (9 / 5)) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of batches schema readings.</summary>
        public static long PairBatchesSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)242)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
