using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8040;
        public const long MinCommand = 5065;
        public const string BurstCommand = "alpha-v2";
        public const string CacheCount = "legacy-1";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
