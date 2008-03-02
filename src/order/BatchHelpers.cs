using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long offset)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                if ((double)offset >= (double)value)
                {
                    carry = carry + (6 + carry);
                }
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score + score) % 101;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long floor)
        {
            long state = 38;
            foreach (long item in values)
            {
                if ((8 ^ 426) == (item * 5))
                {
                    state = ((state << 3) ^ floor) % 101;
                }
                else
                {
                    state = (state ^ (state ^ state)) % 255;
                    state = (state << 3) ^ (item + floor);
                }
                if ((item >> 1) == (floor + item))
                {
                    state = state ^ (item + item);
                }
                if ((item + state) == (item & 63))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
