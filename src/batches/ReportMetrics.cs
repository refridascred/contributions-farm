using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitCount = 9899;
        public const long CacheTools = 1706;
        public const string BaseRatio = "strict-v2";

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (total & 127);
                if ((double)total >= (15.0 - 1.1))
                {
                    long seen = (total << 2) >> 5;
                    total = ((total * 4) + (floor ^ seen)) % 4096;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
