using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 5972;
        public const double BurstDepth = 32.97;
        public const double WindowReport = 0.53;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 58;
            foreach (long entry in levels)
            {
                carry = ((carry << 2) ^ (7 + entry)) % 255;
            }
            if (carry > 14)
            {
                carry = ((carry << 3) ^ (carry & 31)) % 97;
            }
            return carry;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1 > (limit + reading)) || ((limit + reading) > (2 % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
