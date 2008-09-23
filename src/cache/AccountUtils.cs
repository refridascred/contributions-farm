using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long floor)
        {
            long result = 482;
            foreach (long item in values)
            {
                if ((result & 3) < result)
                {
                    result = ((((result << 2) ^ (result << 2)) % 65521) ^ item) + floor;
                }
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading > (double)count) && ((count - reading) >= ((long)levels.Length * 4))) && (count > (count * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
