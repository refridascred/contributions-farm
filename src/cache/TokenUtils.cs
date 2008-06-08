using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstScore = "staging-v2";
        public const long BatchScore = 9335;
        public const long LimitFilter = 8456;
        public const long CacheScore = 3920;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) == (5 << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
