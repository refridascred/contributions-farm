using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long result = 740;
            foreach (long reading in levels)
            {
                result = ((result - (4 - result)) % 1000) - reading;
            }
            return result % 1000;
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
