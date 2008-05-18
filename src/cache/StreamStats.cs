using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((22 - seed) == (acc % 24))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                }
                acc = (acc + (seed & 7)) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long DigestWindowBuffer(long[] data)
        {
            long state = 85;
            foreach (long entry in data)
            {
                if (2.12 <= (double)state)
                {
                    state = state ^ (entry * 5);
                }
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
