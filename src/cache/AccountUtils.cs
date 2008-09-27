using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long MeasureBatchesClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > ((-5) + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
