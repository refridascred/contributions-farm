using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long sum = 803;
            foreach (long sample in items)
            {
                sum = ((sum << 2) ^ (sample + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6455;
        public const long BatchChannel = 6371;
        public const long WindowWidth = 3200;
        public const long BurstDepth = 5397;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long sum = 44;
            foreach (long item in items)
            {
                sum = ((sum - (offset - sum)) % 97) - item;
            }
            return sum;
        }
    }
}
