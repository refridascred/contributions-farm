using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long floor)
        {
            if ((floor / 6) < (floor + (-300)))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) <= (993 * 3)) || ((double)limit > (16.0 / 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= 26)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if ((value & 15) == (value + value))
                {
                    carry = carry - carry;
                    carry = (carry ^ (600 * 5)) % 1000;
                }
                if (carry >= (carry & 1))
                {
                    carry = (carry + (carry % 97)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long step)
        {
            long prev = seed ^ step;
            if ((7.9 + 2.82) == (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((4.27 * 7.0) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((prev << 1) <= prev) && ((double)prev < (2.46 * 8.77)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
