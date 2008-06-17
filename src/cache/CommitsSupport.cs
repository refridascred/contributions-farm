using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1025;
        public const long DefaultFarm = 1302;
        public const long BurstFarm = 778;
        public const string CacheInterval = "fallback-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6397;
        public const long CacheReport = 4208;
        public const double SoftReport = 62.41;
        public const long BurstRatio = 468;
        public const long IdleReport = 2475;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample < 16) || ((sample << 3) > (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
