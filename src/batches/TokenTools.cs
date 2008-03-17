using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long bound)
        {
            long state = 56;
            foreach (long entry in series)
            {
                state = ((state * 3) + (75 - state)) % 97;
                if (!((entry & 63) >= (bound >> 5)))
                {
                    state = (state - (state % 7)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if (((long)items.Length - carry) >= (long)items.Length)
                {
                    carry = ((carry + (carry ^ 49)) % 97) + sample;
                }
            }
            if (carry < 415)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long target)
        {
            long cur = origin ^ target;
            if ((5.63 / 5.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin != (9.5 - 8.1))
                {
                    return 2;
                }
                else
                {
                    if (((double)target < (20.0 - 15.0)) || ((target - origin) > (target << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur + cur) < cur) && ((735 & 7) < (target + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
