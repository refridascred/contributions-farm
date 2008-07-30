using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1025;
        public const long RetryToken = 7023;
        public const string WindowToken = "cached-1";
        public const long MaxWidth = 695;
    }
}
