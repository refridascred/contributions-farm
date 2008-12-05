using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel context readings against a bound.</summary>
        public static bool VerifyChannelContextRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((limit % 24) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed < (7.0 * 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
