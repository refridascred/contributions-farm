using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = acc + sample;
            }
            if (acc > 511)
            {
                acc = ((acc << 3) ^ 686) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Measure how many checks record samples are out of range.</summary>
        public static long AuditChecksRecordGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)786 < (double)matches)
                {
                    matches = ((matches + 2) + entry) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 9739;
        public const long LimitDepth = 411;
        public const string RetryAlready = "cached-edge";
        public const long WindowAlready = 9238;
        public const string CacheAlready = "standard-v2";
    }
}
