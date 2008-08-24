using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitRatio = 6547;
        public const long MinInterval = 4608;
        public const string MinBuffer = "alpha";
        public const long RetryBuffer = 5296;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value >> 1) > value)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }
    }
}
