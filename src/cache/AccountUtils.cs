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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (sample - (-482)))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
