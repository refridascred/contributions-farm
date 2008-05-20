using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((entry + 658) < (total + (long)values.Length))
                {
                    total = (total - floor) % 255;
                }
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3319;
        public const double LimitFarm = 77.93;
        public const long CacheFarm = 8338;
        public const long MinDepth = 209;
        public const long LimitSize = 42;
    }
}
