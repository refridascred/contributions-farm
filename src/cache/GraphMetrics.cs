using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 2989;
        public const string WindowRatio = "stable-1";
        public const long RetryAlready = 4275;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 3029;
        public const double BurstLayout = 31.27;
        public const long MinLayout = 4741;
        public const string CacheLevel = "primary-v2";
        public const string MaxLayout = "strict";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long step)
        {
            if ((double)offset >= (1.8 + 13.0))
            {
                return 2;
            }
            else
            {
                if ((step + 623) < offset)
                {
                    return 4;
                }
                else
                {
                    if (3 <= (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
