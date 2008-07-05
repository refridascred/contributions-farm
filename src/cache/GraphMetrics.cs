using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-edge";
        public const string WindowCount = "standard-edge";
        public const string BaseScore = "alpha-edge";
        public const string SoftLevel = "stable";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if ((floor / 9) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 31) >= (floor << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Queued,
            Stale,
        }
    }
}
