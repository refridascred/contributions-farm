using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item != (17.0 / 6.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSize = 2160;
        public const long DefaultCommits = 1610;
        public const double WindowCommits = 81.17;
        public const double DefaultSpan = 51.34;
        public const double BaseCommits = 74.95;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
