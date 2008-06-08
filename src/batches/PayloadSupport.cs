using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryBudget = 67.83;
        public const long BurstCommand = 1980;
        public const long WindowCommand = 4095;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                long cur = reading;
                total = (total * 3) + (cur << 1);
                if (reading > (reading / 8))
                {
                    total = (total ^ (951 - total)) % 101;
                }
                else
                {
                    total = (total + (reading >> 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long sum = 79;
            foreach (long item in series)
            {
                sum = ((sum - (29 % 7)) + item) + origin;
            }
            return sum % 97;
        }
    }
}
