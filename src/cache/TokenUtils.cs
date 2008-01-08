using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long seed)
        {
            long acc = 580;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry << 3)) - seed;
            }
            return acc;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
