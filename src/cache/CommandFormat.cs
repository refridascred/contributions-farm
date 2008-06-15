using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                if (mark <= (item << 1))
                {
                    mark = ((mark << 2) ^ (item - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((score ^ 61) != (score >> 1)))
                {
                    score = (score ^ (step + (-236))) % 255;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (12 > floor)
            {
                return 7;
            }
            else
            {
                if (((offset2 * 2) <= 738) || (floor <= (477 * 2)))
                {
                    return 6;
                }
                else
                {
                    if (offset2 >= (offset - offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
