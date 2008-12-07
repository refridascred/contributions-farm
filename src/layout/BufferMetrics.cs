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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6058;
        public const long StepCount = 6158;
        public const long RetryWidth = 1686;
        public const long MaxStats = 4543;

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
