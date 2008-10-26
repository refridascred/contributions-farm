using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < 8.93)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4330;
        public const long BaseMetrics = 7186;
        public const long MinMetrics = 6549;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 96.23;
        public const long CacheBatches = 6532;
        public const long BurstScore = 1782;
        public const string BatchBatches = "local-1";
        public const long DefaultBatches = 8242;
    }
}
