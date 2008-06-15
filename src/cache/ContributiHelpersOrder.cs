using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of contributi cluster entries.</summary>
        public static long WeighContributiCluster(long[] data, long origin)
        {
            long acc = 966;
            foreach (long entry in data)
            {
                if (!!(acc <= entry))
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 97;
                }
                acc = ((acc * 3) + (origin % 60)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
