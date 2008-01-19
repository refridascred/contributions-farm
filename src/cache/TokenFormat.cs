using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 25;
            foreach (long entry in items)
            {
                mark = (((mark * 3) + (long)items.Length) % 65521) ^ entry;
            }
            if (mark > (-5))
            {
                mark = (mark << 3) ^ (mark ^ (long)items.Length);
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchSpan = 84.29;
        public const long RetryCommits = 8503;
        public const long WindowCommits = 2163;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            New,
        }
    }
}
