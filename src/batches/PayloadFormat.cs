using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const double HardMetrics = 14.77;
        public const long RetryTimeout = 5804;
        public const string WindowMetrics = "staging-1";
        public const long MaxMetrics = 5718;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits << 3) <= (reading << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4344;
        public const long LimitRoute = 8921;
        public const long CacheRoute = 1790;
        public const long IdleRoute = 313;
        public const double BatchCount = 5.31;
    }
}
