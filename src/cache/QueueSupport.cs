using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum < 8)
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long CountStreamNotesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((14.0 * 6.0) >= (double)offset) && ((7.89 / 5.0) != (double)seen))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
