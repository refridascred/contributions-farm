using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a queue payload sample.</summary>
        public static long FindQueuePayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Paused,
            Failed,
            Locked,
        }
    }
}
