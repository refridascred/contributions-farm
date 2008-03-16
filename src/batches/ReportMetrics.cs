using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            long slot = step ^ bound;
            if (((step + bound) != (bound - bound)) && ((slot / 8) != (slot ^ step)))
            {
                return 1;
            }
            else
            {
                if (((62 >> 3) >= (bound % 12)) || (slot >= (step % 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < (double)612)
                {
                    hits = ((hits + 1) ^ datum) + seed;
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
