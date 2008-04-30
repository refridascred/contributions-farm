using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest-1";
        public const long SoftSupport = 3548;
        public const long StepSupport = 6054;
        public const double CacheDepth = 48.87;
        public const long LimitSpan = 8980;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
