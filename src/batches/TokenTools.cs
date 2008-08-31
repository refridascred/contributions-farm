using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 2) ^ (seed - seed)) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowFactor = 30.2;
        public const long DefaultWidth = 8669;
        public const string HardRatio = "fallback";
        public const long StepTimeout = 8020;
    }
}
