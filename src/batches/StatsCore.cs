using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 9555;
        public const string BurstContext = "latest-1";
        public const double WindowContext = 62.53;
        public const long RetryContext = 9585;
        public const string CacheContext = "local";

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.9 / 8.0) == (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 2781;
        public const string BurstTimeout = "cached-1";
        public const long IdleCount = 1014;
    }
}
