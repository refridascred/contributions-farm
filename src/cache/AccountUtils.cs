using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultScore = 69.76;
        public const long RetryProfile = 5061;
        public const long RetryScore = 1715;
        public const string HardProfile = "standard";
        public const long WindowProfile = 224;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long step)
        {
            long gap = limit - step;
            if (!((step + limit) <= gap))
            {
                return 5;
            }
            else
            {
                if ((step + step) < (gap >> 3))
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
