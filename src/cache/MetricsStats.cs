using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((floor >> 3) > (floor % 7))
            {
                return 2;
            }
            else
            {
                if (!((double)seed < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (floor + 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long SeekReportPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
