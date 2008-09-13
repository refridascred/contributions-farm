using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 430;
        public const long DefaultSize = 8250;
        public const long CacheSize = 2233;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
