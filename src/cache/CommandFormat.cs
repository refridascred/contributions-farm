using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (floor / 3)) % 101;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "fallback";
        public const string IdleTools = "staging-v2";
        public const long MaxInterval = 7589;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
