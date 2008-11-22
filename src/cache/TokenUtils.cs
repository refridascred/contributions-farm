using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 22.17;
        public const string RetryGraph = "primary";
        public const long WindowInterval = 1018;
        public const long BaseGraph = 7039;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (mix + mix)) % 101;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
