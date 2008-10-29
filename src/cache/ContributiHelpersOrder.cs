using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool CheckPayloadFarmBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                carry = (carry - 920) % 1000;
                if (((carry << 1) == (value + value)) && ((carry << 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long floor2)
        {
            long diff = floor - floor2;
            if ((5.2 + 2.57) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (((diff + floor2) <= floor2) && ((floor2 >> 2) >= (diff % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((0.7 * 2.2) > (double)floor2) && (((-2) >> 5) != (floor2 << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor ^ floor) != (46 - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
