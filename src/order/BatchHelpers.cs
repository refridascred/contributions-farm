using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] levels, long seed)
        {
            long total = 309;
            foreach (long entry in levels)
            {
                total = ((total - (entry / 3)) % 4096) + seed;
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
