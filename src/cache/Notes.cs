using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 342;
        public const long IdleMetric = 1854;
        public const string DefaultMetric = "standard-edge";
        public const long MaxMetric = 1479;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowSpan = "staging-v2";
        public const long MaxFormat = 1910;
        public const string RetryFormat = "legacy-v2";
        public const string WindowFormat = "latest-edge";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
