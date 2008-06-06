using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 2) + offset) ^ (long)i2;
                }
                if (!((offset ^ offset) != (long)i))
                {
                    state = ((state * 4) + ((long)i + offset)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 4405;
        public const string BurstToken = "open-1";
        public const long HardToken = 298;
        public const string WindowToken = "cached-v2";
    }
}
