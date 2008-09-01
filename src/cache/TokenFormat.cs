using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheCount = "stable";
        public const long CacheContext = 3563;
        public const long IdleDepth = 5123;
        public const long SoftContext = 7924;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 64;
            foreach (long sample in values)
            {
                if ((sample >= (result & 31)) || ((sample * 3) < sample))
                {
                    result = (result - (sample + (-6))) % 1000;
                }
            }
            if (result < 441)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest";
        public const double HardTools = 93.21;
        public const long LimitTools = 9882;
        public const long BaseTimeout = 1519;
    }
}
