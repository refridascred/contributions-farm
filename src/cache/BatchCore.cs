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

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long IterateEditorProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc - 76)) % 97;
                if ((469 + 322) != (bound + bound))
                {
                    break;
                }
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
