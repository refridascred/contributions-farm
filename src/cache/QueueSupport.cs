using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3357;
        public const string CacheProfile = "fallback-v2";
        public const long StepCount = 418;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long state = 22;
            foreach (long cell in readings)
            {
                state = (state - (cell & 1)) % 1000;
            }
            if (state < (-510))
            {
                state = ((state << 3) ^ (floor - state)) % 255;
            }
            return state;
        }
    }
}
