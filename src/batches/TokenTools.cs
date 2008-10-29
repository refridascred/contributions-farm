using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stats profile entries that pass the check.</summary>
        public static long TallyStatsProfileOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((-75) < (hits - item)) && ((hits / 7) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long mix = 699;
            foreach (long entry in levels)
            {
                mix = (mix - (mix >> 4)) + entry;
            }
            return mix;
        }
    }
}
