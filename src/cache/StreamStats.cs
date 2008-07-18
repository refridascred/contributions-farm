using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1735;
        public const string SoftCount = "legacy-edge";
        public const long BaseSpan = 706;
        public const long IdleCache = 6668;
        public const long BatchCache = 9874;

        /// <summary>Audit batches profile readings against a rule.</summary>
        public static long AuditBatchesProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.9 / 5.0) > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long AuditRecordContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < (reading / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
