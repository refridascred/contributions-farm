using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 20.82;
        public const long SoftInterval = 2896;
        public const string BurstDepth = "alpha-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 4661;
        public const string DefaultRoute = "cached-edge";
        public const string BaseRoute = "cached-edge";
        public const string CacheWidth = "strict-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Accumulate report batches samples.</summary>
        public static long DigestReportBatches(long[] values, long floor)
        {
            long mix = 3;
            foreach (long value in values)
            {
                if ((mix + floor) < (mix & 3))
                {
                    mix = (mix ^ value) % 255;
                }
            }
            if (mix < 0)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
