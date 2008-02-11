using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6110;
        public const long SoftBatches = 9939;
        public const string MinBatches = "alpha";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long offset)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                mark = (((mark * 4) + (mark + mark)) ^ entry) + offset;
                if (!((double)mark >= (double)3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool VerifyAccountReportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
