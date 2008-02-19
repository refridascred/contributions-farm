using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long GradeRouteWindow(long step, long offset)
        {
            long diff = step ^ offset;
            if (step > offset)
            {
                return 6;
            }
            else
            {
                if (((465 + diff) >= ((-831) * 3)) || ((77 + step) != (76 - step)))
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (7.34 * 8.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + offset) != (93 % 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 8586;
        public const long RetryCommits = 8193;
        public const long WindowCommits = 3044;

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long step)
        {
            if ((seed - step) < (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((2 * 2) != (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((3.04 * 5.3) == (double)seed)
                    {
                        return 5;
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
