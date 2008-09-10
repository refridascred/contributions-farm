using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (2.0 + 9.96))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxTimeout = 7482;
        public const string WindowTimeout = "alpha-edge";
        public const long BatchToken = 3401;
        public const long BurstBudget = 215;
        public const long DefaultToken = 9915;
    }
}
