using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if ((7.0 + 7.7) > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin == (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches >= (cell % 64)) || ((double)matches > (2.0 * 1.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
