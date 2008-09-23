using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count >= (item + item)) || ((count * 5) < (item * 3))) && (9.0 <= (double)item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2092;
        public const string StepScore = "open-v2";
        public const string BaseDepth = "cached-edge";
        public const string RetryFilter = "strict-v2";
        public const long MaxWidth = 6876;
    }
}
