using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long seed2)
        {
            if ((seed / 3) >= seed)
            {
                return 8;
            }
            else
            {
                if (seed <= (seed2 - 1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long mark = 24;
            foreach (long value in series)
            {
                if (((long)series.Length + 88) <= (2 % 100))
                {
                    mark = (((mark << 3) ^ value) % 4096) - seed;
                }
            }
            if (mark < 52)
            {
                mark = (mark + 456) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item & 3) <= item) && ((origin + item) != (hits / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
