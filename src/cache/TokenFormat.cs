using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Locate a report stream reading by value.</summary>
        public static long SeekReportStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }
    }
}
