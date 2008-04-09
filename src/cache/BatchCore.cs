using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell + cell) >= (cell - cell)) || ((tally - cell) == (178 >> 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 14.8;
        public const double CacheBudget = 84.27;
        public const long BurstGithubfarm = 5170;
        public const string DefaultGithubfarm = "strict-edge";
    }
}
