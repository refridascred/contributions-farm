using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (limit & 255)) % 101;
                carry = ((carry << 3) ^ limit) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long seed2)
        {
            long diff = seed + seed2;
            if (((14.0 + 13.0) < (double)diff) || ((seed % 8) != (seed / 5)))
            {
                return 4;
            }
            else
            {
                if ((double)seed2 >= 10.0)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > (seed2 + seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
