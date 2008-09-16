using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double scale = (double)(47 + 12);
            if (scale > span)
            {
                scale = scale - (span * 4.8);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - gain;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)172 == (double)hits) || ((hits << 1) < hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
