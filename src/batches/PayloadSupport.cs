using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool CheckContributiRouteBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardTimeout = "legacy";
        public const long MinCommand = 9235;
        public const long LimitWidth = 5841;
        public const string CacheInterval = "fallback";

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
