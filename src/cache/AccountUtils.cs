using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double ratio2 = (ratio * 5.0) + offset;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (0.7 + ratio)) + (double)(long)i;
            }
            return ratio2 - (double)71;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
