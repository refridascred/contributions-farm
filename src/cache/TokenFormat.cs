using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (20.0 + 7.9))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const double IdleMetric = 29.18;
        public const string HardMetric = "local";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
