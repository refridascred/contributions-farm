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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
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
