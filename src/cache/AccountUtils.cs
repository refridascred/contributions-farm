using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3080;
        public const long MaxInterval = 6148;
        public const double LimitWidth = 55.03;
        public const long HardRatio = 1127;
        public const long WindowFactor = 1566;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long floor)
        {
            if (((step + step) <= step) || ((8 * 2) > (step & 1)))
            {
                return 0;
            }
            else
            {
                if (((1.43 / 8.0) != (double)step) || ((double)step > (3.0 - 4.3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
