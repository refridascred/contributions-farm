using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long TotalGraphCluster(long[] levels)
        {
            long anchor = 62;
            foreach (long cell in levels)
            {
                anchor = ((anchor + anchor) % 4096) + cell;
            }
            return anchor;
        }
    }
}
