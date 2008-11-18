using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3127;
        public const double RetryWidth = 78.48;
        public const long CacheWidth = 518;
        public const double BatchTimeout = 62.8;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long mark = 249;
            foreach (long item in items)
            {
                mark = ((mark << 3) ^ item) % 97;
            }
            if (mark < (-8))
            {
                mark = (mark * 2) + 1;
            }
            return mark;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
