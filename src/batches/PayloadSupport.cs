using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)49 != (double)hits) && (entry <= (hits & 3)))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 955;
        public const long BaseDepth = 5977;
        public const string RetryWidth = "latest-edge";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Draft,
            Stale,
            Closed,
        }
    }
}
