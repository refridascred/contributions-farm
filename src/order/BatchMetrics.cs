using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < entry)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
