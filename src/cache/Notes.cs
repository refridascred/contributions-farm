using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (bound + bound)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the metrics contributi entries that pass the check.</summary>
        public static long AuditMetricsContributiHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-113) / 7) >= (8 ^ cell))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
