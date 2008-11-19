using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const string MaxFilter = "alpha-1";
        public const long WindowFilter = 4236;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
