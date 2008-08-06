using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > ((-537) + target)) || ((0.3 * 7.4) == (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long floor)
        {
            if (floor > limit)
            {
                return 1;
            }
            else
            {
                if ((floor * 5) < (floor >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (8.28 - 6.54))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0 + seed) <= (value - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
