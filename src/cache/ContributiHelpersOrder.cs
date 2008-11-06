using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                if (anchor <= entry)
                {
                    anchor = (((anchor << 3) ^ (anchor & 3)) % 97) + origin;
                    anchor = anchor - anchor;
                }
                anchor = (anchor + 276) % 1000;
            }
            return anchor;
        }
    }
}
