using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset * 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate route account readings against a bound.</summary>
        public static bool ValidateRouteAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result + 31;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long seed)
        {
            long gap = bound - seed;
            if ((double)bound <= (double)(-1))
            {
                return 0;
            }
            else
            {
                if (((seed + 8) < (seed + bound)) && ((12.0 / 8.0) == (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((gap / 7) != (seed - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(bound > seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long MatchFilterSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
