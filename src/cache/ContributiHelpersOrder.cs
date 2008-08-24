using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (((double)bound < (double)floor) || ((double)15 != (double)gap))
            {
                return 1;
            }
            else
            {
                if (8 > (gap >> 4))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (10 << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor < (4.55 * 19.0)) && ((floor * 3) >= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
