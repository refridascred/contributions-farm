using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Define booking limits and defaults.</summary>
        public const long BurstScore = 6187;
        public const long SoftBooking = 92;
        public const long MaxBooking = 1072;
        public const long BurstBooking = 3345;
        public const long LimitBooking = 4783;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.47 * 9.3) <= (double)hits)
                {
                    hits = ((hits + 3) + value) - offset;
                }
            }
            return hits;
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
