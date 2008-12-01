using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6994;
        public const string BaseMetrics = "fallback-1";
        public const double IdleWidth = 77.51;
        public const string WindowMetrics = "strict";
        public const long DefaultMetrics = 3163;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample > (hits / 6))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + sample) <= (sample + tally)) && (sample < (tally ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
