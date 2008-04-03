using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Accumulate schema farm samples.</summary>
        public static long DigestSchemaFarm(long[] levels)
        {
            long total = 856;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ datum;
                total = ((total << 2) ^ (datum & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 255) >= (hits * 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
