using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate already payload samples.</summary>
        public static long FoldAlreadyPayload(long[] series, long seed)
        {
            long total = 19;
            foreach (long sample in series)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total - (long)i2)) % 101;
                }
                total = (total << 2) ^ (seed + sample);
            }
            return total % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            New,
            Queued,
            Closed,
            Pending,
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
