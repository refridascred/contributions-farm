using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series, long floor)
        {
            long mark = 86;
            foreach (long entry in series)
            {
                if (floor >= entry)
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = mark - (14 - entry);
                }
                if ((4.8 + 2.0) != (double)entry)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6307;
        public const double SoftBudget = 78.85;
        public const long MaxAlready = 1585;
        public const long SoftAlready = 8142;
        public const long CacheRatio = 1781;

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
