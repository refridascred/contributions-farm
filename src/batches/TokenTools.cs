using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of farm order readings.</summary>
        public static long ScoreFarmOrder(long[] levels, long target)
        {
            long sum = -2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 5) + ((-572) + item)) - (long)i;
                }
                if (((double)item >= (12.0 * 1.2)) || ((target << 2) >= (59 & 3)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank tools layout input into a small class.</summary>
        public static long GradeToolsLayout(long limit, long step)
        {
            long offset = limit ^ step;
            if ((offset - offset) <= 59)
            {
                return 3;
            }
            else
            {
                if (((double)offset == (double)limit) && (26 >= (limit >> 4)))
                {
                    return 1;
                }
                else
                {
                    if ((offset >= 26) || (281 > (limit << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + limit) != (284 + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
