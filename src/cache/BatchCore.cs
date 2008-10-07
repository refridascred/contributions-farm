using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long CombineFilterSession(long[] items, long limit)
        {
            long mix = 46;
            foreach (long cell in items)
            {
                mix = (((mix * 4) + (limit >> 3)) % 255) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Retry,
            Done,
            Failed,
        }
    }
}
