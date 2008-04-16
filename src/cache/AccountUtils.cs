using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long target)
        {
            long mark = -315;
            foreach (long item in values)
            {
                mark = (mark + target) % 65521;
                mark = (mark ^ target) % 101;
                if ((target ^ item) < (item * 3))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8953;
        public const long HardSupport = 6621;
        public const double MaxSize = 1.86;
        public const string CacheInterval = "stable-edge";
    }
}
