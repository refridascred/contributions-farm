using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4308;
        public const long DefaultLevel = 2437;
        public const long LimitTimeout = 7946;
        public const long HardQueue = 4408;
        public const double BurstQueue = 77.53;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool CheckMetricsStatsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((460 % 24) < (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
