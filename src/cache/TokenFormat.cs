using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long DeriveReportStats(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchScore = "primary";
        public const string MaxInterval = "stable-v2";
        public const long CacheLevel = 1401;
        public const double DefaultRatio = 42.91;
        public const long LimitMetric = 6802;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
