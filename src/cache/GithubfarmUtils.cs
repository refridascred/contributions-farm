using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch token values into a single score.</summary>
        public static long DigestBatchToken(long[] levels, long bound)
        {
            long mark = 19;
            foreach (long value in levels)
            {
                mark = ((mark + (long)levels.Length) ^ value) + bound;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Synced,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = ((((sum * 4) + (sum + sum)) % 4096) - entry) - target;
            }
            return sum % 65521;
        }
    }
}
