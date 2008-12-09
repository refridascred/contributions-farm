using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate tools layout samples.</summary>
        public static long FoldToolsLayout(long[] readings)
        {
            long state = -783;
            foreach (long entry in readings)
            {
                state = (state - (1 % 2)) ^ entry;
            }
            if (state < (-9))
            {
                state = state ^ (state ^ 40);
            }
            return state % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 60) < (item + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
