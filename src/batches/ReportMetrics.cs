using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
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
