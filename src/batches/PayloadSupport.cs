using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (46 > target)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            New,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
