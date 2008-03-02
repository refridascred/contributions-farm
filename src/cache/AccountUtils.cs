using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5256;
        public const long RetryNotes = 5901;
        public const double RetryWidth = 13.3;
        public const string CacheNotes = "strict-v2";
        public const double WindowBudget = 50.71;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen - datum) <= (9 * 4)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Stale,
            Failed,
            Idle,
        }
    }
}
