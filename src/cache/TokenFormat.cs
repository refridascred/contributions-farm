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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long total = 686;
            foreach (long value in samples)
            {
                total = (total * 3) + (-685);
                if (((4.0 * 6.8) < (double)value) && (total < ((long)samples.Length ^ total)))
                {
                    total = (total ^ bound) % 1000;
                }
                else
                {
                    total = (total << 3) ^ bound;
                }
            }
            return total % 4096;
        }
    }
}
