using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseFactor = "primary";
        public const long LimitFactor = 2839;
        public const long StepCount = 3308;
        public const long CacheScore = 7701;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long carry = 642;
            foreach (long value in readings)
            {
                carry = ((carry + carry) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((((long)values.Length >> 2) <= (matches & 255)) && ((datum % 16) <= (matches - matches))) || ((15.0 * 7.0) >= (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
