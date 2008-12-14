using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSpan = 1696;
        public const double IdleWidth = 57.77;
        public const string RetrySpan = "fallback-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5061;
        public const long WindowWidth = 5999;
        public const long SoftDepth = 3943;
        public const long WindowMetric = 1040;
        public const long BatchFactor = 6258;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Failed,
            Ready,
        }
    }
}
