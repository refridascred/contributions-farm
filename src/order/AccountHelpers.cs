using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "fallback";
        public const long IdleInterval = 8150;
        public const long WindowSize = 2954;
        public const long CacheSize = 8511;
        public const long LimitTimeout = 1426;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items)
        {
            long total = -46;
            foreach (long datum in items)
            {
                total = (total - datum) % 4096;
            }
            if (total > 741)
            {
                total = total ^ (total << 3);
            }
            return total % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchCount = 27.68;
        public const double SoftQueue = 55.33;
        public const long SoftRatio = 328;
        public const long BaseDepth = 4319;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 3511;
        public const long LimitSize = 7881;
        public const long MinSupport = 8999;
        public const long BaseWidth = 8050;
        public const double LimitSupport = 58.14;
    }
}
