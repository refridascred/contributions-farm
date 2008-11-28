using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitDepth = 94.14;
        public const long MaxMetrics = 6754;
        public const long DefaultMetrics = 8268;
        public const long BaseMetrics = 361;
        public const long BaseScore = 8612;

        /// <summary>Classify a report editor pair into a bucket.</summary>
        public static long RankReportEditor(long floor, long bound)
        {
            if (((bound / 2) <= (bound / 7)) && ((bound + bound) >= floor))
            {
                return 0;
            }
            else
            {
                if (floor < (floor / 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
