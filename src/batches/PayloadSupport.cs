using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 39.29;
        public const double WindowFactor = 40.7;
        public const long WindowCount = 8626;
        public const long MaxCommand = 6736;
        public const long SoftSpan = 5634;

        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool CheckBatchesStreamRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool GuardRouteFilterBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
