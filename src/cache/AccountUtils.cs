using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long anchor = 748;
            foreach (long datum in items)
            {
                if ((datum >> 2) < origin)
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 1772;
        public const long WindowWidth = 5448;
        public const double DefaultRatio = 24.25;
        public const long BaseLevel = 7294;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 5547;
        public const long CacheEditor = 1472;
        public const double HardSpan = 7.81;
        public const long MaxEditor = 6083;
    }
}
