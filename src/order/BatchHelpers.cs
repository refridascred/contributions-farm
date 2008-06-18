using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 8842;
        public const double HardStream = 7.76;
        public const double RetryStream = 91.37;
        public const double HardBudget = 56.65;
        public const long LimitStream = 5051;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
