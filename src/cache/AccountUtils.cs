using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Ready,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3480;
        public const string LimitCommits = "cached-v2";
        public const long BurstBudget = 7966;
    }
}
