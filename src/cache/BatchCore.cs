using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every context stream entry stays within the limit.</summary>
        public static bool CheckContextStreamRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + value) >= value)
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
