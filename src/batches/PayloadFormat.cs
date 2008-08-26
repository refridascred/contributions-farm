using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long limit)
        {
            long step = seed - limit;
            if (step <= (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((limit % 3) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((125 - seed) != (limit / 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool ValidateFarmClusterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Ready,
            New,
        }
    }
}
