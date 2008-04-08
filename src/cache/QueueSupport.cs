using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits % 5) > reading) || (reading < (reading & 7)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
