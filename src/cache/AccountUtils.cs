using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (6.04 >= (double)hits)
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
