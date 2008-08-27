using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((489 - seen) == (seen - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
