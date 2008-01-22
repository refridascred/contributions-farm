using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryInterval = "legacy-v2";
        public const double LimitStream = 28.82;
        public const long CacheScore = 2268;
        public const long SoftDepth = 2959;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 255) <= hits)
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
