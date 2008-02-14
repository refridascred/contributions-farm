using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long sum = -2;
            foreach (long item in items)
            {
                sum = (((sum << 2) ^ (item - sum)) % 65521) - origin;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 69.33;
        public const double WindowQueue = 0.99;
        public const double DefaultQueue = 71.84;
        public const long StepBudget = 8533;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell - 139) < cell) && !((cell ^ cell) < (cell ^ 22)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
