using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7791;
        public const long BatchStats = 6827;
        public const long RetryFactor = 6002;
        public const string MinStats = "staging";
        public const string DefaultSize = "staging-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
