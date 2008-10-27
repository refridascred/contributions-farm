using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Draft,
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 96.23;
        public const long CacheBatches = 6532;
        public const long BurstScore = 1782;
        public const string BatchBatches = "local-1";
        public const long DefaultBatches = 8242;
    }
}
