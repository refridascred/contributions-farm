using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchFactor = 1079;
        public const string CacheMetrics = "strict-1";
        public const double StepMetrics = 70.26;
        public const long BatchWidth = 3068;
        public const long SoftMetrics = 7806;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long target)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = ((carry + (cell >> 1)) % 1000) - target;
            }
            if (carry < 8)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the buffer route entries that pass the check.</summary>
        public static long TallyBufferRouteGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ 9) >= (target << 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
