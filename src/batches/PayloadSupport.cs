using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5180;
        public const long WindowSize = 7431;
        public const long SoftInterval = 1107;
        public const long DefaultCounter = 8931;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 81.43;
        public const double BatchWidth = 98.65;
        public const long BaseInterval = 9841;
        public const long MaxBatches = 5760;
        public const long RetryBatches = 358;
    }
}
