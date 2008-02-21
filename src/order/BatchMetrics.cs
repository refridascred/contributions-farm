using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "local";
        public const long IdleInterval = 6554;
        public const double DefaultRecord = 49.57;
        public const string LimitRecord = "standard-v2";

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (594 & 7))
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

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long limit)
        {
            if ((origin << 3) >= (origin ^ origin))
            {
                return 2;
            }
            else
            {
                if ((limit & 127) >= (99 ^ 0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] values)
        {
            long mark = -62;
            foreach (long cell in values)
            {
                if (mark >= (cell * 4))
                {
                    mark = (mark + (cell - mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long mix = 874;
            foreach (long item in data)
            {
                mix = (((mix * 4) + (item + item)) % 255) + limit;
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix % 97;
        }
    }
}
