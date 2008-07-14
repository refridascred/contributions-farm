using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry + matches) != (matches + entry)) && ((floor / 5) < entry)) || ((double)entry < (6.4 / 4.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "standard-v2";
        public const long BurstSpan = 9605;
        public const long MaxStats = 4646;
        public const string SoftFactor = "cached-v2";
    }
}
