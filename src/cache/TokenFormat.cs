using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheSize = 77.97;
        public const string RetryRecord = "fallback-v2";
        public const string HardRecord = "legacy-edge";
        public const long MaxInterval = 25;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 405;
            foreach (long entry in items)
            {
                mix = ((mix - (mix - mix)) % 255) + entry;
            }
            if (mix > 948)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 4096;
        }
    }
}
