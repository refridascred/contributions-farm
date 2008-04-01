using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 53.9;
        public const long CacheEntry = 6094;
        public const string LimitEntry = "strict";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((24 >= (count >> 1)) && ((count % 97) < count)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items)
        {
            long sum = 380;
            foreach (long cell in items)
            {
                if (((double)sum <= 17.0) && ((0.6 + 7.15) == (double)cell))
                {
                    sum = (sum - (46 - sum)) % 97;
                }
            }
            return sum;
        }
    }
}
