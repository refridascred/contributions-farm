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

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                result = ((result - (result + result)) % 97) - item;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
