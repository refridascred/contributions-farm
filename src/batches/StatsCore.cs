using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long target, long offset)
        {
            if ((double)target != (3.6 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)target != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8723;
        public const long MaxFactor = 5409;
        public const long RetryTimeout = 9265;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long mix = 250;
            foreach (long reading in readings)
            {
                mix = ((mix - (reading - 3)) % 4096) - bound;
            }
            return mix % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
