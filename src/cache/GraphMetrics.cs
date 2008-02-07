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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Ready,
            Retry,
        }

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
