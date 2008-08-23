using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7612;
        public const double BatchMetric = 80.2;
        public const string BatchDepth = "alpha-1";
        public const string MinMetric = "cached-edge";
        public const long CacheMetric = 470;

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long BucketCounterEditor(long offset, long step)
        {
            if (8 > (offset + step))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (1.12 + 8.19))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Draft,
            Ready,
            Retry,
            Closed,
        }
    }
}
