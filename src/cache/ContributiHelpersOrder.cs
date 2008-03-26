using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Done,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long step)
        {
            long anchor = -943;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ (step >> 3)) ^ sample;
            }
            if (anchor < 375)
            {
                anchor = (anchor << 3) ^ (anchor ^ 12);
            }
            return anchor;
        }
    }
}
