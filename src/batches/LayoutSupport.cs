using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "cached-edge";
        public const long DefaultSpan = 9290;
        public const double BurstChannel = 8.88;
        public const string WindowInterval = "staging";
        public const string LimitChannel = "standard-v2";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 2) >= (seen * 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
