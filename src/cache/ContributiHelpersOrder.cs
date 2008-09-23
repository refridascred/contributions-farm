using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long offset)
        {
            if ((offset - offset) >= (floor + 856))
            {
                return 1;
            }
            else
            {
                if (offset < (offset / 9))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Paused,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowCount = 3420;
        public const string BurstRoute = "open-1";
        public const string HardSpan = "stable";
        public const long IdleInterval = 5935;
    }
}
