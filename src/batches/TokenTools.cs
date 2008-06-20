using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "standard-1";
        public const long RetryCount = 9712;
        public const long MaxMetrics = 7888;

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
