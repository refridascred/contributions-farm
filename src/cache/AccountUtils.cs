using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = carry ^ target;
                if (target < (carry * 4))
                {
                    carry = carry - (target + (long)series.Length);
                    continue;
                }
                if (!((entry + target) >= entry))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry < 568)
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((614 / 6) >= cur) && ((cur % 10) >= floor))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) <= (floor2 - cur))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 < (floor & 15)) && ((double)cur >= (2.6 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.93 > (double)floor) || ((floor * 4) < 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
