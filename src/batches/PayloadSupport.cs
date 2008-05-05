using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits / 4) <= hits)
                {
                    hits = ((hits + 2) + cell) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long offset)
        {
            long mix = 367;
            foreach (long sample in levels)
            {
                if (((8 - offset) > (mix + offset)) || ((mix & 15) < mix))
                {
                    mix = (mix ^ mix) ^ sample;
                }
            }
            return mix;
        }
    }
}
