using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7.76 * 9.0) == (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
