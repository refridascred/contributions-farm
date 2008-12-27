using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every filter route entry stays within the limit.</summary>
        public static bool ValidateFilterRouteBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long seed)
        {
            long mix = 50;
            foreach (long item in data)
            {
                mix = ((mix << 3) ^ (seed + 5)) ^ item;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 6254;
        public const string BaseWidth = "fallback-v2";
        public const long LimitMetrics = 7444;
        public const double HardSize = 65.68;
        public const long SoftMetrics = 5744;
    }
}
