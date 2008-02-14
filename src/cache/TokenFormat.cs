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

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseFactor = 92.57;
        public const long DefaultBatches = 7570;
        public const long MinBatches = 9113;

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
