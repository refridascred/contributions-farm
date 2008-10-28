using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                if ((target - target) > (target * 4))
                {
                    state = (state << 2) ^ ((long)i - target);
                    continue;
                }
                if (!((target >> 4) >= 459))
                {
                    state = (state << 3) ^ 327;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8350;
        public const double BaseFactor = 70.75;
        public const long BurstMetrics = 7002;
    }
}
