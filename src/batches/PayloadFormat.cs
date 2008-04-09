using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5684;
        public const long BatchChannel = 2586;
        public const long HardChannel = 6081;
        public const string MinSpan = "primary-edge";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry << 3) ^ (seed / 4)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
