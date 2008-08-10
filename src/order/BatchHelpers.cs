using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many cache cluster samples are out of range.</summary>
        public static long CountCacheClusterGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= datum)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 65.61;
        public const long LimitSize = 9967;
        public const string SoftRatio = "fallback-edge";
    }
}
