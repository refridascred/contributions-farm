using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long offset)
        {
            if ((7.2 * 9.7) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((-37) <= (799 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) > seed) || ((seed & 127) >= (seed / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
