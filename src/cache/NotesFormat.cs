using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((floor >> 4) < (value + floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSize = 9.21;
        public const long MaxLayout = 5347;
        public const long BurstLayout = 9137;
        public const long RetryLayout = 8409;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 4976;
        public const double LimitDepth = 0.43;
        public const long HardDepth = 8690;
        public const long StepScore = 8046;
        public const long WindowRatio = 8965;
    }
}
