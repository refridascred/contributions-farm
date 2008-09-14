using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long CountMetricsRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((double)tally >= (9.0 * 2.0)))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 19.37;
        public const long WindowScore = 6612;
        public const string BurstMetric = "strict-edge";
        public const long WindowWidth = 5142;
        public const string RetryRatio = "local-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
