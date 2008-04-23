using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 9551;
        public const long BurstDepth = 8047;
        public const long BaseTimeout = 8535;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
