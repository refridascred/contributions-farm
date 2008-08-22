using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the support already series from a seed.</summary>
        public static long StepSupportAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (acc & 1)) % 65521;
                acc = acc ^ ((long)i & 255);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings, long target)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                if (6.0 >= (double)item)
                {
                    carry = (carry - (item - carry)) + target;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((((long)i >> 3) > (total + target)) || (7.2 < (double)total)))
                {
                    total = total - ((long)i & 7);
                }
                if (total <= (total / 7))
                {
                    total = (total << 3) ^ total;
                    total = (total - (target << 1)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many batches graph samples are out of range.</summary>
        public static long AuditBatchesGraphOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((target >> 3) <= (target + reading)) || ((target ^ target) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
