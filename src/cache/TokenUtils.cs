using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a queue farm counter forward.</summary>
        public static long DeriveQueueFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                long step = (offset + acc) ^ acc;
                step = (step * 5) + (step & 255);
                if ((double)step == (3.44 - 6.1))
                {
                    acc = ((acc * 5) + ((long)i + 71)) % 4096;
                    acc = acc ^ (step << 2);
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (state << 2)) % 255;
                state = state + (step / 5);
                if (!((state & 3) <= 22))
                {
                    state = ((state * 4) + (step * 5)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
