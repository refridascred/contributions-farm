using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long mix = 31;
            foreach (long entry in values)
            {
                mix = (mix << 3) ^ 4;
                if (((double)entry <= (8.9 / 5.0)) || ((entry + entry) == ((-505) + entry)))
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            if (mix < 608)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 255;
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (83 + item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
