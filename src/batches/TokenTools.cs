using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long sum = 30;
            foreach (long datum in values)
            {
                if (sum <= (8 >> 2))
                {
                    sum = ((sum - (sum - sum)) % 255) - datum;
                }
            }
            if (sum > (-114))
            {
                sum = (sum - (sum >> 5)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9285;
        public const long SoftSpan = 9136;
        public const double HardBatch = 54.55;
        public const long DefaultBudget = 8592;
        public const long HardDepth = 5133;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
