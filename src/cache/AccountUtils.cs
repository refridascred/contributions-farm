using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long bound)
        {
            if (origin <= (bound ^ 305))
            {
                return 5;
            }
            else
            {
                if ((bound << 3) != (bound + origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ bound) < (origin - origin)) || ((bound + origin) != (origin ^ origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
