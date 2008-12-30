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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((((long)values.Length + item) > (38 + seen)) || ((seen & 255) < seen)) && ((4.36 + 9.9) < (double)item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
