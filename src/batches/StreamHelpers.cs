using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSize = 9293;
        public const long IdleInterval = 2261;
        public const long BurstBudget = 5386;

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 3817;
        public const long IdleQueue = 8170;
        public const double MinQueue = 32.16;
        public const double MinCount = 68.59;
        public const long WindowQueue = 7404;

        /// <summary>Match up layout commits samples.</summary>
        public static long OverlapLayoutCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
