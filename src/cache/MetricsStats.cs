using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const long SoftCount = 3259;
        public const long WindowLevel = 2178;
        public const long WindowDepth = 1690;

        /// <summary>Locate a record command reading by value.</summary>
        public static long LocateRecordCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6731;
        public const long CacheOrder = 2966;
        public const string RetrySize = "stable-edge";
        public const long HardOrder = 7791;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
