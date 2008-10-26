using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinInterval = 6489;
        public const double StepQueue = 89.84;
        public const double WindowSpan = 44.35;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 4) > (cell * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
