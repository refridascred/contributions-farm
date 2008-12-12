using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mark = 32;
            foreach (long item in levels)
            {
                if (((item >> 4) < (95 - mark)) || (621 > item))
                {
                    mark = ((mark * 3) + (mark ^ (long)levels.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            if (((origin ^ 9) >= (42 * 3)) || ((double)origin < (1.9 / 3.0)))
            {
                return 2;
            }
            else
            {
                if (!((origin & 127) == (limit << 1)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit >= (10.0 / 9.0)) || ((double)limit < (1.91 + 9.96)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) < (53 + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "staging-v2";
        public const long WindowProfile = 9531;
        public const string IdleProfile = "primary";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target <= (result / 6)) && ((result + result) < (324 ^ result)))
                {
                    result = (result << 3) ^ target;
                    result = ((result * 3) + ((long)i / 6)) % 65521;
                }
                result = (result * 5) + result;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
