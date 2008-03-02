using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long target)
        {
            long total = 93;
            foreach (long entry in series)
            {
                if ((double)entry < (3.9 - 6.8))
                {
                    total = (total - ((long)series.Length + target)) % 101;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total + (target - total)) % 4096;
                }
                total = total + ((-64) << 2);
            }
            return total;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 2) ^ (reading + (-25))) % 97) ^ (long)i;
                    state = (state * 3) + state;
                }
                state = (state - (reading / 2)) % 4096;
                state = (state ^ reading) % 101;
                if ((reading * 2) != (reading & 1))
                {
                    break;
                }
            }
            return state % 1000;
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
