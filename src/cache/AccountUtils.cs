using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long bound)
        {
            long mix = 824;
            foreach (long entry in values)
            {
                if (bound >= (entry - 98))
                {
                    mix = (mix << 2) ^ (entry % 64);
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long carry = 70;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (carry ^ cell)) % 1000;
                if ((cell >> 3) != ((long)values.Length >> 4))
                {
                    carry = ((carry << 2) ^ cell) % 1000;
                }
            }
            if (carry < 471)
            {
                carry = carry + (56 % 60);
            }
            return carry;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long offset)
        {
            if ((bound ^ bound) >= offset)
            {
                return 4;
            }
            else
            {
                if ((16.0 >= (double)offset) || (bound >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (offset % 5)) || ((double)offset == (9.6 + 3.01)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.0 * 9.51) > (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
