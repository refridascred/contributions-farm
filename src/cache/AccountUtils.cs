using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ seed) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long delta = origin + target;
            if (((double)origin > 4.34) && ((origin + origin) == (origin >> 5)))
            {
                return 6;
            }
            else
            {
                if (!((delta >> 2) == (origin - 387)))
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
