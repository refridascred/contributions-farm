using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowTimeout = "fallback-1";
        public const double BatchFilter = 72.76;
        public const long SoftFactor = 6883;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            New,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
