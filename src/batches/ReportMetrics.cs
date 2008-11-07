using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values, long floor)
        {
            long state = 6;
            foreach (long cell in values)
            {
                state = ((state + (2 % 8)) % 97) - cell;
            }
            if (state > 91)
            {
                state = (state + (floor + 621)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7287;
        public const long WindowEntry = 495;
        public const long CacheCount = 4201;
        public const double WindowInterval = 0.27;
        public const long BaseEntry = 5666;
    }
}
