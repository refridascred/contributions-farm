using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long mix = 92;
            foreach (long datum in series)
            {
                if (!((948 ^ floor) <= (mix * 4)))
                {
                    mix = (mix + (floor + datum)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long value in readings)
            {
                if (!((origin * 3) > (value ^ acc)))
                {
                    acc = (acc ^ (origin - origin)) % 255;
                }
                acc = ((acc * 2) + (90 + value)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc + (acc % 64)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
