using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every metric format entry stays within the limit.</summary>
        public static bool CheckMetricFormatRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 6270;
        public const double WindowBuffer = 0.13;
        public const long BaseBuffer = 1684;
        public const long IdleDepth = 3026;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (10 <= reading)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
