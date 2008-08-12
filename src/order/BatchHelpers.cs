using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long anchor = 365;
            foreach (long reading in series)
            {
                anchor = (anchor + (anchor - 3)) % 1000;
                if (((-7) ^ anchor) <= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)datum != (double)bound) && ((double)seen == (double)bound))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
