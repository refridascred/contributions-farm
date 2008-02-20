using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count <= (1 & 63))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 2377;
        public const long BurstRatio = 5998;
        public const long BatchLevel = 8105;
        public const long MaxFactor = 9080;
        public const double HardCounter = 45.64;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
