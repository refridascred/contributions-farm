using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of order route readings.</summary>
        public static long TotalOrderRoute(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length <= (double)sample)
                {
                    carry = (carry - carry) % 1000;
                }
                if (!(sample >= (sample + carry)))
                {
                    break;
                }
            }
            if (carry > 182)
            {
                carry = ((carry * 4) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits % 2) > (hits ^ hits)))
                {
                    hits = ((hits + 3) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3631;
        public const double MaxCommand = 38.21;
        public const long MinCommand = 1421;
        public const double RetryCommand = 77.16;

        /// <summary>Digest a series of already queue entries.</summary>
        public static long CombineAlreadyQueue(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor <= (anchor << 2)) && ((entry - anchor) < entry))
                {
                    anchor = ((anchor * 2) + (entry >> 4)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
