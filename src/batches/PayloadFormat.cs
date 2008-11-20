using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state / 3) < (state + step))
                {
                    state = ((state * 3) + (36 * 4)) % 101;
                }
                else
                {
                    state = (state + ((long)i & 3)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            long gap = seed - seed2;
            if (seed <= gap)
            {
                return 1;
            }
            else
            {
                if ((gap & 3) < (gap % 5))
                {
                    return 6;
                }
                else
                {
                    if ((gap >> 5) == ((-5) ^ gap))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
