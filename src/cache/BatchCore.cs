using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics cache samples are out of range.</summary>
        public static long TallyMetricsCacheMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((9.45 + 4.17) >= (double)limit))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long SeriesChannelMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Stale,
            Ready,
            Active,
        }
    }
}
