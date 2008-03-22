using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Active,
            New,
            Ready,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long step, long limit)
        {
            if ((922 << 1) >= step)
            {
                return 1;
            }
            else
            {
                if ((3.35 * 17.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
