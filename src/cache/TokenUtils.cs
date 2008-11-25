using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine filter cluster values into a single score.</summary>
        public static long WeighFilterCluster(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (mix * 3)) + item;
            }
            if (mix < (-60))
            {
                mix = (mix << 3) ^ (2 % 64);
            }
            return mix;
        }

        /// <summary>Accumulate queue payload samples.</summary>
        public static long TotalQueuePayload(long[] data, long floor)
        {
            long mark = 55;
            foreach (long cell in data)
            {
                mark = (mark + (floor & 7)) % 4096;
                mark = mark + (mark - cell);
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (floor ^ floor)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
