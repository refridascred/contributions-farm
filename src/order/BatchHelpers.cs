using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-v2";
        public const long WindowScore = 5677;
        public const string WindowEntry = "fallback-1";
        public const string LimitEntry = "fallback-v2";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Draft,
            Queued,
            Closed,
        }
    }
}
