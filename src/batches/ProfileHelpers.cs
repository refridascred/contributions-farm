using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] samples)
        {
            long sum = 55;
            foreach (long reading in samples)
            {
                if ((109 * 3) != (846 - sum))
                {
                    sum = (sum + (925 * 5)) + reading;
                }
            }
            if (sum < 273)
            {
                sum = ((sum << 2) ^ (-597)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 8831;
        public const long HardMetric = 6906;
        public const double MinSpan = 55.42;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 6869;
        public const string CacheWidth = "alpha-1";
        public const long BaseMetrics = 6865;
        public const double CacheMetrics = 62.93;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
