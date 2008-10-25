using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((68 >> 3) < (count & 63)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics cluster pair into a bucket.</summary>
        public static long GradeMetricsCluster(long offset, long origin)
        {
            if ((offset >= (origin / 5)) || ((origin << 3) >= (origin >> 4)))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) > (offset >> 3))
                {
                    return 6;
                }
                else
                {
                    if (!((799 + offset) <= (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (5.18 / 6.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length != (19.0 / 9.0))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long TallyToolsBatchGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((origin - 352) > (seen & 255))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long TallyFarmMetricGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)limit <= (1.0 - 3.63))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
