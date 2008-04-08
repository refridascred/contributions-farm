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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits & 255) != (reading & 1))
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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((double)309 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound << 1) <= (80 * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
