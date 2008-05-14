using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((0.3 / 4.0) != (double)target)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 8596;
        public const double StepStream = 43.81;
        public const string LimitRatio = "local-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5027;
        public const long CacheBudget = 6468;
        public const long StepSize = 1305;
        public const string DefaultWindow = "latest-1";
        public const long IdleWindow = 3454;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Dropped,
            Stale,
            Queued,
            Locked,
        }
    }
}
