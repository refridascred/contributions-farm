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

        /// <summary>Rank record window input into a small class.</summary>
        public static long ClassifyRecordWindow(long step, long seed)
        {
            long diff = step - seed;
            if (!((diff & 1) == (diff + seed)))
            {
                return 2;
            }
            else
            {
                if ((2.0 + 8.44) == (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
