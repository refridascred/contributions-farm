using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a profile tools pair into a bucket.</summary>
        public static long BucketProfileTools(long offset, long target)
        {
            if ((double)target > (2.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if ((offset >> 2) < (target >> 5))
                {
                    return 4;
                }
                else
                {
                    if (offset > (1 ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((747 + target) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((810 + step) > (hits + item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
