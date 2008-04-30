using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long floor)
        {
            long mix = 889;
            foreach (long entry in readings)
            {
                if ((double)mix >= 1.79)
                {
                    mix = ((mix ^ (6 ^ 5)) % 101) - floor;
                }
                mix = ((mix * 3) + (entry * 5)) % 97;
            }
            return mix % 97;
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
