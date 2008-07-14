using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long CacheSession = 8040;
        public const long MinWidth = 292;
        public const long LimitRatio = 8470;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
