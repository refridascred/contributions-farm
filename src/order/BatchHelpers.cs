using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next cluster contributi value from a seed.</summary>
        public static long IterateClusterContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result - origin) % 65521;
                result = ((result * 4) + (long)i) % 97;
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
