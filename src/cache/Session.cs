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

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 63.58;
        public const long RetryRecord = 6258;
        public const long MaxRecord = 7094;
        public const double HardRecord = 24.98;
        public const double HardCount = 25.09;

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
