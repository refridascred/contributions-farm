using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long limit)
        {
            if ((limit >> 5) >= floor)
            {
                return 6;
            }
            else
            {
                if (((floor & 255) >= floor) || (floor >= (limit - limit)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
