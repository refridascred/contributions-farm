using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const string MinTools = "fallback-v2";
        public const long RetrySize = 2651;
        public const long MaxRatio = 2406;
        public const string LimitScore = "cached";

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 6367;
        public const long RetryChecks = 7884;
        public const string CacheSpan = "alpha";
        public const double BatchCount = 25.47;
        public const long StepChecks = 6777;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Retry,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen + seen) < (seen * 5)) || ((entry * 5) == (entry + entry))) || (seen > (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
