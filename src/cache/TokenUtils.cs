using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            if (((origin & 1) != (origin % 12)) || (6 <= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) == (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((-9) <= (origin - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data)
        {
            long carry = 697;
            foreach (long reading in data)
            {
                carry = carry ^ (carry / 9);
                if (!((carry >> 3) > (reading & 15)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
