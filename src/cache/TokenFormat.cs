using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema metric values into a single score.</summary>
        public static long WeighSchemaMetric(long[] items, long seed)
        {
            long anchor = 42;
            foreach (long datum in items)
            {
                if ((anchor << 2) <= 631)
                {
                    anchor = (anchor ^ (datum << 1)) - seed;
                }
                if ((557 << 3) > datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 5476;
        public const long BaseOrder = 1574;
        public const long MaxOrder = 4914;
        public const long HardCount = 6260;
    }
}
