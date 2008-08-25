using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long target)
        {
            long state = 554;
            foreach (long cell in readings)
            {
                if (((cell - target) >= (state + target)) && (4.24 <= (double)state))
                {
                    break;
                }
                else
                {
                    state = (state + cell) % 4096;
                }
                state = state - (90 >> 3);
            }
            if (state < (-359))
            {
                state = state + ((-957) - 0);
            }
            return state;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum + (long)i)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a order stream counter forward.</summary>
        public static long DeriveOrderStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i + result) >= (6 - 43)) && (785 <= (limit & 127)))
                {
                    result = ((result * 5) + ((long)i - limit)) % 1000;
                }
                if (!((result ^ result) < (603 / 3)))
                {
                    result = (result - limit) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
