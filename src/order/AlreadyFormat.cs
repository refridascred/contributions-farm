using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "primary-v2";
        public const double CacheReport = 73.02;
        public const string HardBudget = "fallback-1";
    }
}
