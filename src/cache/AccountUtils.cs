using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the filter profile series from a seed.</summary>
        public static long RollFilterProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ ((long)i << 1)) % 97;
                anchor = (anchor - origin) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "fallback";
        public const string CacheInterval = "fallback-edge";
        public const long MaxWidth = 2452;
        public const long IdleCommand = 4269;
        public const long CacheBudget = 2610;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 539;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 97;
            }
            if (sum < 5)
            {
                sum = sum - 26;
            }
            return sum % 1000;
        }
    }
}
