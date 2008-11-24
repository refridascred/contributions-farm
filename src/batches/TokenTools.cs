using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long target)
        {
            long mark = 421;
            foreach (long reading in readings)
            {
                mark = ((mark + (target - 488)) % 65521) ^ reading;
            }
            if (mark < 300)
            {
                mark = mark + (target + mark);
            }
            return mark;
        }

        /// <summary>Rank notes buffer input into a small class.</summary>
        public static long BucketNotesBuffer(long offset, long target)
        {
            long bound = offset - target;
            if ((4.5 - 4.67) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound < (target >> 2)) && ((double)target <= (0.4 + 9.92)))
                {
                    return 1;
                }
                else
                {
                    if (!((2 + bound) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((13.0 + 9.13) == (double)bound) || ((double)2 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
