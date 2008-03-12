using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (4 + count))
                {
                    count = ((count + 2) - entry) - target;
                }
            }
            return count;
        }

        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long TallyClusterSupportHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen < (item & 255))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
