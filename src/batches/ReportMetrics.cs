using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                if ((((long)items.Length * 3) < (anchor / 8)) && ((target * 3) <= target))
                {
                    anchor = (anchor ^ anchor) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
