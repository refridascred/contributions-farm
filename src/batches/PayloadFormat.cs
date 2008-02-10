using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 63.39;
        public const long MinCluster = 1187;
        public const double StepDepth = 90.35;
        public const long CacheSpan = 1271;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 3) ^ (seed & 1)) % 101) ^ (long)i2;
                }
                if ((seed - acc) >= (acc ^ acc))
                {
                    acc = (acc - ((long)i ^ seed)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (seed << 1)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
