using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the token cluster series from a seed.</summary>
        public static long IterateTokenCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long acc = 645;
            foreach (long item in values)
            {
                if (2.41 < (double)item)
                {
                    acc = ((acc << 3) ^ 886) - seed;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 3) + (acc / 3)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
