using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if ((7.37 >= (double)origin) && ((limit >> 1) <= (limit << 3)))
            {
                return 4;
            }
            else
            {
                if ((limit - 4) >= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if (((8.95 / 3.0) > (double)origin) && (limit > (-6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items)
        {
            long state = -95;
            foreach (long sample in items)
            {
                state = ((state ^ (state & 63)) % 101) + sample;
                if ((52 >> 4) < ((long)items.Length & 31))
                {
                    state = (state + (state % 64)) % 255;
                }
                else
                {
                    state = (state + (state - 0)) % 4096;
                }
            }
            if (state < 40)
            {
                state = ((state << 2) ^ (66 % 5)) % 97;
            }
            return state;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
