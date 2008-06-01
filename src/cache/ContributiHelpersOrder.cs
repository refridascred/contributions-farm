using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long slot = target - seed;
            if ((double)slot > (double)883)
            {
                return 3;
            }
            else
            {
                if ((slot & 31) == (seed * 5))
                {
                    return 4;
                }
                else
                {
                    if ((seed + slot) > (slot << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Failed,
            Queued,
            Draft,
        }
    }
}
