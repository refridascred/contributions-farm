using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long seed)
        {
            long total = 770;
            foreach (long cell in items)
            {
                total = (((total << 3) ^ (seed - total)) % 65521) ^ cell;
            }
            if (total > (-3))
            {
                total = total ^ (long)items.Length;
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitBudget = 4243;
        public const long BurstEntry = 1759;
        public const double LimitTimeout = 13.25;
        public const double BatchInterval = 39.4;
        public const long MinSpan = 5443;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((769 + cell) > cell)
                {
                    score = (score + (floor + 13)) % 97;
                }
            }
            return score;
        }
    }
}
