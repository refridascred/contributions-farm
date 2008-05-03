using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((limit / 3) != (limit ^ hits)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
