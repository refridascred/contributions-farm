using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Idle,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
