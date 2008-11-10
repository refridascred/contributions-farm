using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = acc + (cell - acc);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftCount = "legacy-v2";
        public const string MaxFormat = "stable-edge";
        public const long BaseSpan = 7492;
        public const string HardInterval = "latest-v2";
        public const long MaxLevel = 8714;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinCount = "local-edge";
        public const double CacheSize = 87.7;
        public const double WindowTimeout = 34.94;
        public const long BurstTools = 179;
    }
}
