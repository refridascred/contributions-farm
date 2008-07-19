using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 9.19;
        public const long CacheDepth = 9672;
        public const double LimitMetric = 91.98;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) == ((-9) << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Ready,
            Queued,
            Dropped,
            Done,
        }
    }
}
