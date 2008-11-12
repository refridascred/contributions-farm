using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (782 > (cell % 7))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item - 2) < (677 - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long acc = 4;
            foreach (long item in series)
            {
                acc = (acc ^ item) % 1000;
                acc = acc ^ ((long)series.Length + acc);
                if (item <= (floor - acc))
                {
                    acc = (acc * 3) + (acc - item);
                }
            }
            if (acc > 974)
            {
                acc = ((acc << 2) ^ floor) % 255;
            }
            return acc;
        }
    }
}
