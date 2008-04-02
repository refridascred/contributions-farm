using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            New,
            Idle,
            Paused,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!!((65 + sample) < (6 % 97)))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
