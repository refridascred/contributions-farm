using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long total = 9;
            foreach (long item in samples)
            {
                if ((total << 3) != (total + (-95)))
                {
                    total = ((total * 5) + (total - item)) - offset;
                }
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 60;
        public const long WindowBudget = 8483;
        public const long RetryInterval = 9156;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long score = 0;
            foreach (long value in series)
            {
                score = (((score - (66 ^ score)) % 97) + value) + origin;
            }
            return score % 97;
        }
    }
}
