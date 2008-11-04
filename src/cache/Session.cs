using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Synced,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double floor)
        {
            double scale = floor;
            if (scale < (ratio * 6.88))
            {
                scale = scale + ratio;
            }
            return scale - scale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((1 + datum) > (datum - bound))
                {
                    hits = hits + 3;
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
