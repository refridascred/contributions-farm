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

        /// <summary>Adjust a context notes reading.</summary>
        public static double ScaleContextNotes(double scale, double offset)
        {
            double rate = 1.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + offset) - (double)(long)i;
            }
            return rate - (scale / 9.0);
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
