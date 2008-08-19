using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowDepth = 9320;
        public const double BurstStream = 39.67;
        public const long CacheInterval = 774;
        public const string BatchStream = "primary-edge";
        public const long CacheScore = 8361;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryLevel = 43.84;
        public const double BurstSize = 58.42;
        public const double HardQueue = 77.76;
        public const double BaseSpan = 11.95;
        public const double LimitSize = 40.79;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Dropped,
            Failed,
            Paused,
        }
    }
}
