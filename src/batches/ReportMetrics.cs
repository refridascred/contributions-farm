using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((6.7 / 8.0) < (double)reading)
                {
                    anchor = anchor + (anchor / 8);
                }
            }
            if (anchor < 49)
            {
                anchor = anchor + (97 / 3);
            }
            return anchor;
        }
    }
}
