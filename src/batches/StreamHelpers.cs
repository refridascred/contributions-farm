using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next entry notes value from a seed.</summary>
        public static long SeriesEntryNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Retry,
            New,
            Active,
            Idle,
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
