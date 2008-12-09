using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long origin)
        {
            if ((origin <= (origin ^ origin)) || ((floor + floor) > origin))
            {
                return 3;
            }
            else
            {
                if ((-23) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((origin % 7) > (floor << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
