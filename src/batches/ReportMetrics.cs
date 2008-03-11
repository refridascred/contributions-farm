using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 71.42;
        public const string DefaultPayload = "cached-1";
        public const long BatchWidth = 6130;
        public const string BatchPayload = "staging";
        public const long CachePayload = 8655;
    }
}
