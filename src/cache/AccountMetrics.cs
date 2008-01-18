using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1487;
        public const string IdleTimeout = "stable";
        public const long BurstTools = 8147;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of profile support readings.</summary>
        public static long ScoreProfileSupport(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ 5) % 4096) + (long)i;
                }
                sum = sum - (71 / 5);
                if (sum > floor)
                {
                    sum = (sum ^ (55 * 2)) % 97;
                }
                else
                {
                    sum = (sum - (entry ^ floor)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3315;
        public const long BaseSession = 8645;
        public const long BaseBudget = 4736;
        public const long SoftFactor = 6946;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            New,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((1.39 - 2.4) != (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
