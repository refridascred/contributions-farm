using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long LocateSchemaBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count the farm batch entries that pass the check.</summary>
        public static long MeasureFarmBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item ^ count) != (389 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
