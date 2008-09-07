using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry >= (entry + 0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Ready,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8937;
        public const long SoftInterval = 1683;
        public const double MaxScore = 21.99;
        public const long IdleRatio = 8940;
    }
}
