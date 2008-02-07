using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((777 + cell) > (long)levels.Length) || ((44 + cell) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= (seen % 60))
                {
                    seen = ((seen + 2) ^ sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
