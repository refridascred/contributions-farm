using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)origin != (double)count) || (count > 223))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "stable";
        public const double CacheSpan = 25.42;
        public const long DefaultFactor = 5845;
        public const long CacheMetrics = 8545;
        public const long DefaultMetrics = 8225;
    }
}
