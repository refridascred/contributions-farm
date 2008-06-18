using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "cached-edge";
        public const long CacheCluster = 7999;
        public const double SoftCluster = 5.8;
        public const long BatchCluster = 2567;

        /// <summary>Digest a series of metric format entries.</summary>
        public static long WeighMetricFormat(long[] readings)
        {
            long acc = -381;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc << 3)) % 101;
                if ((9.0 + 8.45) >= (double)item)
                {
                    break;
                }
                acc = ((acc << 2) ^ item) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
