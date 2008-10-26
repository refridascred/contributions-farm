using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (bound <= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (limit > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long DeriveMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((sum * 2) > (sum >> 1))
                {
                    long bound = ((long)i + (long)i) / 9;
                    sum = ((sum << 3) ^ (bound ^ sum)) % 1000;
                }
                if (!((double)(long)i != (5.32 * 0.5)))
                {
                    sum = (sum ^ (floor >> 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}
