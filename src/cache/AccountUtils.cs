using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + (seed / 2)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if ((limit - 5) <= 97)
            {
                return 5;
            }
            else
            {
                if (12.0 >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor < (1.0 + 7.0)) || (floor >= (limit ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
