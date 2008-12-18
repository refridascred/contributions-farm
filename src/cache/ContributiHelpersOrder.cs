using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long state = -4;
            foreach (long item in data)
            {
                if (((4.27 / 2.0) == (double)item) || (((long)data.Length - item) < (item << 3)))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long floor, long target)
        {
            if (!((floor + floor) < (target - target)))
            {
                return 0;
            }
            else
            {
                if (((target + floor) > (7 + floor)) || ((target % 24) < target))
                {
                    return 5;
                }
                else
                {
                    if (!((floor + floor) >= (floor ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((0 & 15) == (floor + floor)))
                        {
                            return 3;
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
