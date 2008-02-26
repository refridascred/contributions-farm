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

        /// <summary>Validate editor order readings against a bound.</summary>
        public static bool ValidateEditorOrderBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
