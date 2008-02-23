using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 15.87;
        public const long LimitContributi = 2444;
        public const double WindowCount = 63.56;
        public const long WindowScore = 6809;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long acc = 13;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + (limit >> 1)) % 255) - reading;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseRatio = "fallback-edge";
        public const long BatchSize = 4776;
        public const string MaxTimeout = "legacy-v2";
        public const long SoftSchema = 7268;
        public const double RetryDepth = 36.14;
    }
}
