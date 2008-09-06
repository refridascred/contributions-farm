using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((target + value) != ((-737) - target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
