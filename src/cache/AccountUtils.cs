using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            if ((bound >> 1) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if (bound > limit)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
