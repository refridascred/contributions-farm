using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings, long origin)
        {
            long carry = 5;
            foreach (long item in readings)
            {
                carry = (carry + (item % 97)) - origin;
                carry = carry - item;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long bound = origin + floor;
            if ((floor >= origin) || ((0.62 / 3.0) == (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= (floor >> 2))
                {
                    return 2;
                }
                else
                {
                    if (bound < (origin & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor + bound) != (floor << 3)))
                        {
                            return 3;
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
}
