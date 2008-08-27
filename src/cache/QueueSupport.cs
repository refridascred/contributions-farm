using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) <= (count % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Synced,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3510;
        public const long CacheDepth = 6755;
        public const long CacheNotes = 1437;
    }
}
