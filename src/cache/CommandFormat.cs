using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long SortWindowBatch(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((5.84 + 8.6) >= (9.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((limit2 ^ limit2) <= (offset + limit)) || (limit <= (-703)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
