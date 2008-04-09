using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstSpan = 53.85;
        public const double SoftTimeout = 11.35;
        public const long LimitCounter = 1100;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(((double)count > (10.0 - 5.88)) || ((reading - count) <= count)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long offset)
        {
            long carry = 280;
            foreach (long value in data)
            {
                carry = (carry * 5) + value;
                if ((double)value != (double)offset)
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry + (78 + 475);
            }
            return carry;
        }

        /// <summary>Audit profile cluster readings against a rule.</summary>
        public static long MeasureProfileClusterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((7.74 - 5.0) == (double)tally)
                {
                    tally = ((tally + 2) ^ value) + floor;
                }
            }
            return tally;
        }
    }
}
