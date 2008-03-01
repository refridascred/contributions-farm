using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Closed,
            Retry,
            Idle,
        }

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
