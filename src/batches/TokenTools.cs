using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool CheckToolsLayoutRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long step)
        {
            if ((double)step >= 1.66)
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (5.4 - 9.81))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
