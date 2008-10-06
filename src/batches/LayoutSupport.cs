using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((cell % 5) != (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "fallback";
        public const long BaseStream = 8576;
        public const string SoftStream = "staging";
        public const long WindowStream = 9869;
        public const long StepScore = 3714;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Pending,
            Draft,
        }
    }
}
