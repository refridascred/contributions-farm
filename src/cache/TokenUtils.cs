using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 3) > matches)
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheBudget = 8005;
        public const long StepQueue = 2448;
        public const long MinQueue = 7924;
        public const long BatchFactor = 4762;
    }
}
