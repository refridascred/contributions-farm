using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4833;
        public const long CacheTimeout = 5421;
        public const long SoftFactor = 1261;
        public const long LimitNotes = 2828;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((617 / 3) <= (limit - limit))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Done,
            Idle,
        }
    }
}
