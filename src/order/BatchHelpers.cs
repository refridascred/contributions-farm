using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double gain2 = (offset * 6.51) / 7.0;
            return gain2 - gain;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long target)
        {
            long mix = -104;
            foreach (long item in values)
            {
                mix = ((mix + (item & 7)) % 97) + target;
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ 701;
            }
            return mix % 1000;
        }
    }
}
