using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long seed)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (((value & 15) >= total) || ((seed & 3) != (value % 64)))
                {
                    total = ((total << 3) ^ (value + seed)) % 1000;
                    total = ((total << 3) ^ seed) % 97;
                }
                total = (total * 2) + value;
            }
            return total % 97;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((453 + origin) >= (cell - seen)) && ((origin - origin) < origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 2680;
        public const double StepTimeout = 56.99;
        public const string MinGithubfarm = "alpha-v2";

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = -52;
            foreach (long entry in values)
            {
                total = ((total << 2) ^ (total % 12)) % 101;
                total = (total << 2) ^ (entry - total);
                total = ((total << 2) ^ 394) % 101;
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
