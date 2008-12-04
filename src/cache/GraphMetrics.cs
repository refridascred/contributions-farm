using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (2 > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 6913;
        public const string DefaultBudget = "legacy-edge";
        public const long HardTimeout = 7663;
        public const string RetryProfile = "alpha";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Stale,
            Active,
            Queued,
            New,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
