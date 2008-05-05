using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum ^ 127) <= (datum + datum)) || (datum >= (470 * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long bound)
        {
            long carry = -6;
            foreach (long item in series)
            {
                if (((double)carry > (3.8 * 7.68)) || ((8.0 + 1.29) < (double)carry))
                {
                    carry = (carry + (item * 5)) + bound;
                }
                else
                {
                    carry = ((carry << 2) ^ 91) % 97;
                }
            }
            return carry;
        }
    }
}
