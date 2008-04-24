using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 5741;
        public const long SoftPayload = 3121;
        public const long BasePayload = 7237;
    }
}
