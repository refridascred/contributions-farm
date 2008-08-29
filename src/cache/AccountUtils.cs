using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5267;
        public const string CacheEntry = "open-1";
        public const long WindowFactor = 4898;
        public const long LimitCount = 9464;
        public const long LimitEntry = 4142;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (0.8 >= (double)item)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)step >= 15.0)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
