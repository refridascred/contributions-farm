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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - seen) > (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
