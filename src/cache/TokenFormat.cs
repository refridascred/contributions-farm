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

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7724;
        public const double SoftWindow = 23.35;
        public const double LimitSize = 72.71;
        public const double MaxSize = 45.14;

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
