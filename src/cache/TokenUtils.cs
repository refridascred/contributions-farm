using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long next = origin - target;
            if (next <= (origin + target))
            {
                return 2;
            }
            else
            {
                if ((10.0 * 9.4) >= (double)next)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 6644;
        public const long WindowScore = 5771;
        public const string CacheSize = "alpha-v2";
        public const long DefaultInterval = 3617;
        public const long BaseBudget = 3651;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
