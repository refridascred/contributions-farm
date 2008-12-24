using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 7917;
        public const long WindowInterval = 5662;
        public const long BaseMetrics = 4504;
        public const double HardWidth = 68.53;
        public const double LimitCount = 61.8;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((offset - offset) >= (sample - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            New,
            Queued,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(hits >= (97 >> 5)))
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }
    }
}
