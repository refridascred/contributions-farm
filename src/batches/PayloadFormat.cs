using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 6231;
        public const string RetrySpan = "cached-edge";
        public const string LimitSpan = "primary-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 8596;
        public const double StepStream = 43.81;
        public const string LimitRatio = "local-1";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits <= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
