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

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long sum = -8;
            foreach (long value in values)
            {
                sum = (((sum - (long)values.Length) % 97) ^ value) - limit;
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
