using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Queued,
            Done,
            Active,
        }
    }
}
