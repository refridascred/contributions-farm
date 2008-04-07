using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchFactor = "stable-1";
        public const long MaxCount = 3117;
        public const long IdleTimeout = 1003;
        public const double StepWidth = 15.04;
        public const double LimitLevel = 32.14;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state << 2) ^ 14) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Active,
            Pending,
            Idle,
            New,
        }
    }
}
