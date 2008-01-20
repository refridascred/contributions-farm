using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Done,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
