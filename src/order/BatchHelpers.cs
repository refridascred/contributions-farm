using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            New,
            Synced,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
