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

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheFactor = "fallback-1";
        public const long LimitTimeout = 680;
        public const long MaxPayload = 1;
        public const double StepPayload = 18.24;
        public const long MinPayload = 4866;

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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - cell) >= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
