using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 5905;
        public const long LimitCache = 808;
        public const long CacheLevel = 9625;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 255) > 382)
                {
                    hits = ((hits + 1) + entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Failed,
            Stale,
        }
    }
}
