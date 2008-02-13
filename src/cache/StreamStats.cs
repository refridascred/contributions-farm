using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 6530;
        public const double BurstWidth = 83.54;
        public const long IdleRatio = 1084;
        public const string CacheSpan = "latest-edge";
        public const long CacheFactor = 5473;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Retry,
            New,
            Failed,
            Closed,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry - (8 + carry)) ^ (long)i2;
                }
                carry = (carry + (carry & 1)) % 255;
                carry = (carry * 3) + (carry >> 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
