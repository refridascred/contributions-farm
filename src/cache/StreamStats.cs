using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 95.95;
        public const long SoftFactor = 154;
        public const string SoftSession = "legacy-v2";
        public const long SoftDepth = 1799;
        public const long BatchSpan = 965;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Dropped,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long CombineNotesBatches(long[] levels)
        {
            long carry = 575;
            foreach (long datum in levels)
            {
                carry = (carry ^ carry) ^ datum;
            }
            return carry;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
