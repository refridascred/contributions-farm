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

        /// <summary>Grade a schema window value against two limits.</summary>
        public static long BucketSchemaWindow(long origin, long seed)
        {
            long slot = origin + seed;
            if (((619 + 30) <= (origin + 32)) && (slot < (seed << 3)))
            {
                return 3;
            }
            else
            {
                if (598 < (origin % 24))
                {
                    return 2;
                }
                else
                {
                    if (!(slot < (7 + slot)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route entry readings.</summary>
        public static long OverlapRouteEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
