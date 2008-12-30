using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long TallyChecksSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (0.9 + 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 4419;
        public const long LimitGraph = 9701;
        public const long BurstGraph = 3822;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
