using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long seed)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 2) ^ 286) % 65521;
                if ((5.2 * 6.61) == (double)sample)
                {
                    break;
                }
            }
            if (anchor > 929)
            {
                anchor = (anchor * 2) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics tools entries that pass the check.</summary>
        public static long CountMetricsToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) >= (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 4947;
        public const string BatchOrder = "latest-v2";
        public const string StepOrder = "strict";
        public const long IdleOrder = 1966;
        public const double BaseLevel = 86.48;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 4110;
        public const long MaxMetrics = 8426;
        public const string DefaultMetrics = "stable";
        public const double MinMetrics = 60.46;
        public const long BatchCount = 8368;
    }
}
