using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Ready,
            Stale,
            Pending,
            New,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (689 < (tally - tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
