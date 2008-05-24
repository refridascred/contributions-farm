using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "standard-edge";
        public const long LimitEntry = 7209;
        public const double LimitCount = 98.12;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6019;
        public const long MaxLevel = 5704;
        public const double DefaultBatch = 51.42;
        public const long IdleBatch = 6083;
        public const double BatchDepth = 66.38;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3121;
        public const long BurstRatio = 7866;
        public const long DefaultCount = 6083;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
