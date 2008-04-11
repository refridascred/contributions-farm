using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 204;
            foreach (long entry in series)
            {
                anchor = anchor ^ (entry ^ entry);
                if (entry < (49 & 15))
                {
                    anchor = ((anchor << 3) ^ (entry & 3)) % 4096;
                }
                if ((double)entry < (2.9 / 4.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Closed,
            Queued,
            Pending,
        }
    }
}
