using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long CombineContributiCluster(long[] items)
        {
            long mark = 32;
            foreach (long datum in items)
            {
                mark = (mark + 42) + datum;
            }
            return mark;
        }

        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long AuditBatchSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) == (seen * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleSpan = "standard-v2";
        public const long RetryChannel = 8835;
        public const long HardSpan = 196;
        public const long WindowBudget = 6177;
    }
}
