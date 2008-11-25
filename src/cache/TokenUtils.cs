using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "legacy-edge";
        public const long CacheMetric = 5139;
        public const long MaxMetric = 9805;
        public const long BaseMetric = 7807;

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
