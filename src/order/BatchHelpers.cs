using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry % 24) < (step >> 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2671;
        public const long BurstFilter = 2747;
        public const long BurstInterval = 5464;
    }
}
