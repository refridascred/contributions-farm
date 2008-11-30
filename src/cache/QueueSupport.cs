using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long AuditSupportCommitsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((17.0 / 7.0) < (double)(long)values.Length)
                {
                    count = ((count + 3) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Ready,
            Retry,
            New,
        }
    }
}
