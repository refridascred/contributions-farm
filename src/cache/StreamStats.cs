using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 8036;
        public const long IdleEntry = 895;
        public const long CacheEntry = 6794;
        public const string MinBudget = "fallback-edge";
        public const long LimitBudget = 7690;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
