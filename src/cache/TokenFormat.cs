using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format already readings.</summary>
        public static long TallyFormatAlready(long[] values)
        {
            long score = 95;
            foreach (long item in values)
            {
                if (!((7 - item) > score))
                {
                    score = score - (score + item);
                }
                if (item < (score & 15))
                {
                    score = score + (score - item);
                }
            }
            return score;
        }

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool VerifyContributiGraphBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryDepth = 1015;
        public const long LimitTimeout = 9470;
        public const long WindowCount = 9328;
        public const double CacheDepth = 59.38;
        public const string LimitCommand = "staging";
    }
}
