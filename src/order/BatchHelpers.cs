using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + result) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "strict-1";
        public const long CacheRatio = 849;
        public const long MaxWidth = 7247;
        public const string MaxScore = "fallback";
    }
}
