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

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long target)
        {
            long edge = bound - target;
            if ((double)target < (9.98 * 8.63))
            {
                return 1;
            }
            else
            {
                if ((edge % 8) != (bound & 255))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
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
