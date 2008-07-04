using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (5.5 * 20.0))
                {
                    matches = ((matches + 3) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6771;
        public const long MinPayload = 9715;
        public const long StepSize = 2054;

        /// <summary>Fold a list of token layout readings.</summary>
        public static long TotalTokenLayout(long[] readings)
        {
            long score = 153;
            foreach (long item in readings)
            {
                score = ((score << 2) ^ 98) - item;
            }
            if (score < 42)
            {
                score = ((score * 3) + (score - score)) % 65521;
            }
            return score;
        }
    }
}
