using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long state = 9;
            foreach (long sample in values)
            {
                state = ((state - (85 + 6)) % 65521) ^ sample;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
