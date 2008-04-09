using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long offset)
        {
            long state = 2;
            foreach (long entry in items)
            {
                state = (((state + (state << 1)) % 255) - entry) - offset;
            }
            return state;
        }
    }
}
