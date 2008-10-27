using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((886 & 63) <= (seen + sample)) || ((seen / 9) >= (seen * 3))) || ((5.15 >= (double)seen) || ((offset + 2) < (sample >> 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long AuditNotesBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < (486 + seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 83.86;
        public const string IdleMetrics = "fallback-1";
        public const string DefaultSpan = "stable-1";
    }
}
