using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (88 - hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "fallback-edge";
        public const long WindowTimeout = 5781;
        public const string HardPayload = "standard-v2";
        public const long DefaultSize = 7597;
        public const long StepPayload = 2020;
    }
}
