using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSize = 1922;
        public const long WindowTools = 4639;
        public const string DefaultTools = "fallback-1";
        public const long CacheTools = 1310;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a metric route counter forward.</summary>
        public static long RollMetricRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score << 2) ^ 3;
                score = ((score << 3) ^ score) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
