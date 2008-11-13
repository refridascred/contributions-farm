using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a graph tools reading by value.</summary>
        public static long LookupGraphToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
