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

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long CountFarmAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((6 & 15) >= datum) && ((hits <= (datum / 2)) && ((hits * 2) < 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
