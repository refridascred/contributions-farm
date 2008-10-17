using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryWidth = 2746;
        public const long WindowBudget = 4581;
        public const long BaseInterval = 6015;

        /// <summary>Compare every pair of format route readings.</summary>
        public static long OverlapFormatRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
