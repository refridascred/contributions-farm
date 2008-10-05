using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of filter buffer readings.</summary>
        public static long OverlapFilterBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel buffer counter forward.</summary>
        public static long RollChannelBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (9.0 >= (double)origin)
                {
                    sum = (sum ^ ((long)i & 15)) % 255;
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum - sum) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = (state - (target << 2)) % 97;
                if ((294 ^ (long)i) != (target * 3))
                {
                    state = (state + (state - state)) % 1000;
                    state = (state ^ ((long)i >> 2)) % 65521;
                }
                else
                {
                    state = (state ^ (long)i) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
