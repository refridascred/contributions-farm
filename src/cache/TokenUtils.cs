using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long SortBatchProfile(long limit, long target)
        {
            if (limit < target)
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) <= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
