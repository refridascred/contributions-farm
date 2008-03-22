using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long floor)
        {
            long score = 59;
            foreach (long cell in readings)
            {
                if (((floor >> 1) != ((-268) ^ cell)) || ((floor >> 1) > (651 & 3)))
                {
                    score = (score ^ (floor - 727)) % 97;
                }
                if ((score + cell) >= (cell % 8))
                {
                    break;
                }
            }
            if (score > 986)
            {
                score = ((score * 3) + score) % 97;
            }
            return score;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
