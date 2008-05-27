using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Locate a token report reading by value.</summary>
        public static long LocateTokenReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
