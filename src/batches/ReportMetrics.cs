using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 503;
            foreach (long datum in levels)
            {
                if ((datum % 16) < (datum + total))
                {
                    total = (total + datum) % 4096;
                }
            }
            if (total < 6)
            {
                total = (total + (total >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Queued,
            Ready,
            Idle,
            Stale,
        }
    }
}
