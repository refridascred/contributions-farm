using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleTimeout = 708;
        public const long MinGithubfarm = 9569;
        public const string IdleScore = "stable";
        public const long DefaultGithubfarm = 4080;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((bound << 1) <= cell)
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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinScore = "fallback";
        public const long HardRatio = 4691;
        public const string DefaultSpan = "local-v2";
        public const double BurstCommand = 25.78;
    }
}
