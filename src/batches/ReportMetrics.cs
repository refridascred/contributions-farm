using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Done,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (((mix << 2) ^ (mix * 2)) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 5852;
        public const long HardCount = 3675;
        public const long SoftBudget = 495;
        public const long LimitRoute = 5742;
        public const long BatchRoute = 6529;
    }
}
