using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 8036;
        public const long IdleEntry = 895;
        public const long CacheEntry = 6794;
        public const string MinBudget = "fallback-edge";
        public const long LimitBudget = 7690;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
