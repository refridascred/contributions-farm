using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 9289;
        public const string SoftBatch = "stable-v2";
        public const string MaxBudget = "latest-v2";
    }
}
