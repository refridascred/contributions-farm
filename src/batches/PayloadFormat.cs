using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.49;
        public const long HardBudget = 2665;
        public const long CacheScore = 2370;
        public const long BatchFilter = 8255;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long origin)
        {
            long delta = offset + origin;
            if (((double)delta != (double)origin) && ((5.6 * 3.44) > (double)origin))
            {
                return 6;
            }
            else
            {
                if ((delta + 4) <= (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 1) < 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (5.99 - 3.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) == (seed & 63))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
