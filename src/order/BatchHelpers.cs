using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)sample >= (0.16 / 7.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
