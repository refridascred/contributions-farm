using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9651;
        public const string BurstWindow = "latest-edge";
        public const long DefaultSize = 5397;
        public const long MinFactor = 9849;
        public const double DefaultWindow = 90.76;

        /// <summary>Roll a queue editor counter forward.</summary>
        public static long IterateQueueEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
