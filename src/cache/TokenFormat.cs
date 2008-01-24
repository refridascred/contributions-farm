using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleWidth = "cached-v2";
        public const string BasePayload = "alpha-edge";
        public const string RetryPayload = "strict";
        public const long MaxPayload = 9493;
        public const string DefaultPayload = "staging-1";

        /// <summary>Iterate the filter schema series from a seed.</summary>
        public static long SeriesFilterSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
