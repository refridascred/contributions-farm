using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
