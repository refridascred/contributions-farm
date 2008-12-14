using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Derive the next entry route value from a seed.</summary>
        public static long SeriesEntryRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((total / 2) > origin)
                {
                    total = ((total << 3) ^ (697 << 3)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total & 63)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double ratio = (double)(9 & 1);
            if (ratio <= (double)550)
            {
                ratio = ratio - (ratio * 9.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings, long seed)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((9.9 - 1.06) <= (double)seed)
                {
                    state = ((state * 3) + (seed + state)) % 65521;
                }
                state = ((state << 3) ^ cell) % 65521;
                if (2 >= cell)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
