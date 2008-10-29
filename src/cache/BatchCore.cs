using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryLevel = "strict-1";
        public const long CacheNotes = 9087;
        public const double BaseRatio = 36.73;
        public const long BurstSize = 2237;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
