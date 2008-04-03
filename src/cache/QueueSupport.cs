using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + value) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
