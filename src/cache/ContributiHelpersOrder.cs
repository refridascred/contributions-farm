using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if ((double)mix != (double)54)
                {
                    mix = (mix - entry) - bound;
                }
            }
            return mix;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (ratio * 9.29))
            {
                rate = rate + (4.0 / 8.0);
            }
            else
            {
                rate = rate - ratio;
            }
            return rate + (span * 2.0);
        }
    }
}
