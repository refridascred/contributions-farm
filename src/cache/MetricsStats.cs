using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long mark = 72;
            foreach (long cell in values)
            {
                mark = ((((mark << 3) ^ mark) % 97) + cell) + limit;
                mark = (mark ^ (mark * 2)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long CountBatchesFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(offset <= (228 % 97)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Classify a metric window pair into a bucket.</summary>
        public static long GradeMetricWindow(long floor, long offset)
        {
            if (!((32 + floor) == (offset & 63)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 2) >= (-905))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
