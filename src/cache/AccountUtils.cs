using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 590;
            foreach (long entry in readings)
            {
                if ((7.0 - 4.58) <= (double)entry)
                {
                    carry = (carry ^ (entry >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long step)
        {
            if (!((9.0 * 1.9) >= (double)seed))
            {
                return 8;
            }
            else
            {
                if (step >= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) > seed) || ((seed >> 3) < (step & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (step - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
