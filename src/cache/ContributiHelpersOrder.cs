using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 33;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ 1) - reading;
                mix = (mix + (303 / 3)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - 82) <= (datum + datum))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
